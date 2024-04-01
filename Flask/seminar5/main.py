from typing import Optional

from fastapi import FastAPI
from fastapi.responses import JSONResponse
from pydantic import BaseModel

app = FastAPI()


class Task(BaseModel):
    title: str
    description: str
    status: Optional[bool] = False


tasks = [
    {
        'id': 1,
        'title': 'first',
        'description': 'text',
        'status': True
    },
    {
        'id': 2,
        'title': 'twice',
        'description': 'text',
        'status': False
    },
]
count = len(tasks)


@app.get('/tasks/')
async def get_tasks(status: bool = None):
    print(type(status))
    res = []
    if status is not None:
        for item in tasks:
            if item['status'] == status:
                res.append(item)
        return res
    return tasks


@app.get('/tasks/{id}')
def get_task_id(id: int):
    for item in tasks:
        if item['id'] == id:
            return item
    return JSONResponse({'error': 'ID not found'}, 404)


@app.post('/tasks/')
async def create_tasks(task: Task):
    global count
    count += 1
    res = {
        'id': count,
        'title': task.title,
        'description': task.description,
        'status': task.status
    }
    tasks.append(res)
    return JSONResponse({'message': 'Success'}, 201)


@app.put('/tasks/{id}')
async def update_task(id: int, task: Task):
    for item in tasks:
        if item['id'] == id:
            item.update(task)
    return JSONResponse({'message': 'Success'}, 200)


@app.delete('/tasks/{id}')
async def delete_task(id: int):
    for item in tasks:
        if item['id'] == id:
            tasks.remove(item)
            return JSONResponse({'message': 'Success'}, 200)
    return JSONResponse({'error': 'ID not found'}, 404)
