# Calculadora Juros Composto
API que retorna o valor futuro de uma aplicação e ou emprestimo a 1% ao ano

Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final = Valor Inicial * (1 + juros) ^ Tempo

Valor inicial é um decimal recebido como parâmetro Juros é 1% ou 0,01 (fixo no código) Tempo é um inteiro, que representa meses, também recebido como parâmetro ^ representa a operação de potência Resultado final deve ser truncado (sem arredondamento) em duas casas decimais

Exemplo: /calculajuros?valorinicial=100&meses=5 Resultado esperado: 105,10
