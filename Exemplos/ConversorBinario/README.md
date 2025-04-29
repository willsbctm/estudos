
# Base binária

Representada por 1 e 0. Exemplo: 11001 na base binária equivale a 25 na decimal.

### Transformar binário em decimal

#### 11001:

- 1 x (2 ^ 4) = 16
- 1 x (2 ^ 3) = 8
- 0 x (2 ^ 2) = 0
- 0 x (2 ^ 1) = 0
- 1 x (2 ^ 0) = 1

16 + 8 + 0 + 0 + 1 = 25

Em resumo: Varremos dígito por dígito elevado a posição que ocupa do algorismo completo (de 0 a n da direita para a esquerda)

## 10

- 1 x (2 ^ 1) = 2
- 0 x (2 ^ 0) = 0

2 + 0 = 2

### Transformar decimal em binário

### 2
- Etapa 1: Dividimos por 2
    - 2 / 2 = 1
    - 2 % 2 = 0

Se o quociente da divisão for menor do que 2, paramos as divisões nele e coletamos o quociente concatenado com o resto: 10.


### 25

- Etapa 1: Dividimos por 2
    - 25 / 2 = 12
    - 25% % 2 = 1

Guardamos o resto 1 em uma pilha (LIFO)

- Etapa 2: Dividimos por 2 o quociente da última divisão
    - 12 / 2 = 6
    - 12 % 2 = 0
    - Guardamos o resto 0 em uma pilha

- Etapa 3: Dividimos por 2 o quociente da última divisão
    - 6 / 2 = 3
    - 6 % 2 = 0
    - Guardamos o resto 0 em uma pilha

- Etapa 4: Dividimos por 2 o quociente da última divisão
    - 3 / 2 = 1
    - 3 % 2 = 1
    - Como o quociente da divisão é menor do 2, paramos aqui e armazenamos os valores resto e quociente (deve ser o último valor da pilha) numa pilha.

- Resultado da pilha:
1
1
0
0
1

Logo, o valor 25 na base decimal equivale ao valor 11001 na base binária.





