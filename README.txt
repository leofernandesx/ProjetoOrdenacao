Com o objetivo de testar e comparar diferentes algoritmos de ordenação em estados iniciais diferentes e também arrays de tamanhos variaveis, criamos o  repositório "Projeto - Ordenação". 
 
O projeto aqui presente foi desenvolvido pelos seguintes integrantes: 
 
a.	Leonardo Fernando de Lima – RA: 001202005206 
b.	Nathan Resende da Silva Pinto – RA: 001202004595 
 
Os fatores de comparação entre os algoritmos foram: Tempo de execução, quantidade de trocas e comparações durante a ordenação. 
 
Em relação aos algoritmos comparados, foi executado com os principais existente, sendo eles: Bubble Sort, Improved Bubble Sort, Insertion Sort, Selection Sort, Merge Sort, Quick Sort e Shell Sort. 
 
 
Estados de Testes e Fatores de Comparação 
 
Como citado anteriormente, os testes foram realizados com arrays em tamanhos diferentes e também em estados iniciais diferentes. 
Sobre os tamanhos de array, os testes executados contaram com o seguinte: 1.000, 10.000 e 100.000 elementos. 
Já como estados iniciais tivemos o seguinte: Array Ordenado, Array Aleatório e Array em ordem decrescente. 
 
a.	Array Ordenado: Elementos já ordenados. 
b.	Array Aleatório: Elementos de maneira aleátória. 
c.	Array em Ordem Decrescente: Elementos começando do maior para o menor. 
 
Como fatores de comparação do desempenho de cada caso, utilizamos os três seguintes: 
 
a.	Tempo de Execução: O tempo utilizado pelo algoritmo para ordenar o array. 
b.	Quantidade de Trocas: Quantas trocas foram realizadas até finalizar o processo de ordenação. 
c.	Quantidade de Comparações: Quantas comparações foram realizadas entre valores até que o array fosse ordenado. 
 
Algoritmos de Ordenação Utilizados 
•	Bubble Sort: É um algoritmo de ordenação considerado simples que percorre repetidamente a lista, comparando os elementos adjacentes e os trocando caso estiverem na ordem errada.  
A passagem pela lista é repetida até que a lista esteja totalmente organizada, sem a necessidade de trocas.  
 
•	Improved Bubble Sort: Versão otimizada do Bubble Sort, onde temos a adição d euma flag, "Sinalizador". que indo s ehouve alguma troca, significando que a matriz já foi feita e não é necessário outras passagens. 
Neste algoritmo temos uma redução significativa no número de iterações na melhor das hipóteses. 
 
•	Insertion Sort: Também um algoritmo considerado simples, o qual divide o array em duas partes: Uma ordenada e outra não ordenada. O algoritmo pega elementos da parte não organizada e os insere ordenando na parte ordeanda. 
Ele é bem menos eficiente em arrays grandes do que algoritmos mais avançados, porém ainda possui suas vantagens em alguns casos. 
 
•	Selection Sort:  O algoritmo ordena um array encontrando o elemento minimo da parte não ordenada e colocando-o no inicio  repetidamente. Este algoritmo mantém dois sub arrays dentro d eum array principal: A parte ordenada e a parte que precisa ser ordenada. 
Em cada iteração da ordenação por seleção, o elemento minimo do sub array não organizado é escolhido e movido para o subarray organizado. 
 
•	Merge Sort: Algoritmo de ordenação eficiente e estável, trabalha utilizando a estratégia de dividir e conquistar. 
Divide o array em sub arrays ordenados e mescla os mesmos repetidamente até que sobre apenas um array completamente ordenado.. 
 
•	Quick Sort: O Quick Sort é um algoritmo de alta eficiência, ele divide o array em torno de um elemento chamado "pivot", todos os elementeos menores ele coloca d eum lado e todos os elementos maiores do outro lado, repetindo esse processo para as submatrizes resultantes. 
Este algoritmo é muito eficiente para conjuntos de dados de grande porte, de sua complexidae média e a do pior caso serem respectivamente O(nlogn) e O(N^2). 
 
•	Shell Sort: Este é uma versão generalizada do Insertion Sort. Primeiramente ele faz a classificação dos elementos que estão distantes uns dos outros e reduz sucessivamente o intervalo entre os elementos a serem classificados. 
O seu desempenho depende do tipo de sequência usada para um determinado array de entrada. 
