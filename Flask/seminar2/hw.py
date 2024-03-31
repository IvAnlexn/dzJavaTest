import secrets
from flask import (Flask, flash, redirect, render_template, request, session,
                   url_for)


app = Flask(__name__)
app.secret_key = secrets.token_hex()


@app.route('/')
def index():
    context = {'title': 'index'}
    return render_template('base.html', **context)


@app.get('/form/')
def get_form():
    return render_template('form.html')


@app.post('/form/')
def post_form():
    name = request.form.get('name')
    email = request.form.get('email')
    if name and email:
        session['name'] = request.form.get('name')
        session['email'] = request.form.get('email')
        return redirect(url_for('hello', name=name))
    flash('Введите имя и почту!', 'danger')
    return redirect(url_for('get_form'))


@app.route('/hello/<name>')
def hello(name):
    return render_template('hello.html', name=name)


@app.route('/logout/')
def logout():
    if session:
        session.pop('name')
        session.pop('email')

    return redirect(url_for('get_form'))


if __name__ == '__main__':
    app.run(debug=True)
