# Cracking the coding interview

## Índice
1. [Capítulo 1: The Interview Process](#capítulo-1-the-interview-process)
1. [Capítulo 2: Behind the scenes](#capítulo-2-behind-the-scenes)
1. [Capítulo 3: Special Situations](#capítulo-3-special-situations)
1. [Capítulo 4: Before the interview](#capítulo-4-before-the-interview)
1. [Capítulo 5: Behavioral Questions](#capítulo-5-behavioral-questions)
1. [Capítulo 6: Big O](#capítulo-6-big-o)
1. [Referências](#referências)

## Capítulo 1: The interview Process

## Capítulo 2: Behind the scenes 

## Capítulo 3: Special Situations

## Capítulo 4: Before the interview

## Capítulo 5: Behavioral Questions

## Capítulo 6: Big O

- Melhor caso
- Pior caso
- Caso esperado


### Complexidade de espaço


```c#
int sum(int n) { 
    if (n <= 0) { 
        return 0; 
    } 

    return n + sum(n-1); 
} 
```

```bash
sum(4)
    -> sum(3)
        -> sum(2)
            -> sum(1)
                -> sum(0)
```
Cada iteração adicional um elemento na stack: `O(n)`

Exemplo com `n` chamadas, mas com complexidade de espaço `O(1)`:

```c#
int pairSumSequence(int n) {
    int sum = 0; 
    for (inti= 0; i < n; i++) { 
        sum+= pairSum(i, i + 1); 
    } 
    return sum; 
} 

int pairSum(int a, int b) { 
    return a+ b; 
}
```
Existem `n` iterações, mas não são simultâneas


### Eliminar as constantes
Complexidade `O(2n)` ou `O(n)`? Do ponto de vista da notação Big O, seria `O(n)`. 

Complexidade `O(2n)`
```c#
int min = Integer.MAX_VALUE; 
int max = Integer.MIN_VALUE; 
for (int x : array) { 
    if (x < min) min = x; 
    if (x > max) max = x; 
}
```
Complexidade `O(n)`

```c#
int min = Integer.MAX_VALUE; 
int max = Integer.MIN_VALUE; 
for (int x : array) { 
    if (x < min) min = x; 
} 
for (int x : array) { 
    if (x > max) max = x; 
} 
```


### Eliminar termos não dominantes
Considerar apenas o termo dominante. Exemplos:
- `O(n² + n)` => `O(n²)`
- `O(n + log n)` => `O(n)`

#### Logaritmo
a<sup>x</sup> = b  <=>  log<sub>a</sub>b = x
Onde: 
- a é `base`
- b é o `logaritmando`
- x é o `logaritmo`

Exemplo:
2³ = 8 <=> log<sub>2</sub>8 = 3

log<sub>2</sub>x = b <=> 2<sup>b</sup> = x


### Algoritmos com múltplicas partes: Soma x Multiplicação

- Soma de tempo de execução `O(a + b)`
```bash
for (int a : array) { 
    print(a);
} 
for (int b : array) { 
    print(b);
} 
```

- Multiplicação de tempo de execução `O(a * b)`
```bash
for (int a : array) { 
    for (int b : array) { 
        print(a + "," + b);
    } 
} 
```

# Referências

[Cracking the coding interview : 189 programing questions & solutions](https://www.amazon.com.br/Cracking-Coding-Interview-Programming-Questions/dp/0984782850)



<!--

<script src="https://cdn.jsdelivr.net/npm/mermaid@10.8.0/dist/mermaid.min.js"></script>

 -->
