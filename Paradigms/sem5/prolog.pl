sum_list([], 0).

sum_list([Head|Tail], Sum) :-
    sum_list(Tail, TailSum),  % Рекурсивный вызов для хвоста списка
    Sum is Head + TailSum.    % Вычисление суммы головы и суммы хвоста

% Пример использования
sum_list([1, 2, 3, 4, 5], Result).