# Avaliação — Conceitos Básicos, Classes e Objetos, Encapsulamento

**Módulo:** Programação Orientada a Objetos com C# .NET  

---

## Questão 1 — Reserva de Mesa em Restaurante

### Contexto

Um restaurante precisa controlar a disponibilidade de suas mesas. Cada mesa possui uma capacidade máxima de pessoas e pode ser reservada por um cliente, devendo registrar essa ocupação e impedir reservas indevidas.

---

### Regras de negócio

**Toda mesa do restaurante:**

- Possui número e capacidade máxima de pessoas, definidos na criação; capacidade deve estar entre 1 e 10 — valores fora desse intervalo devem impedir a criação com erro
- O estado de ocupação e o nome do cliente não podem ser modificados diretamente de fora
- Para reservar uma mesa:
  - Nome do cliente não pode ser nulo ou vazio — deve gerar erro
  - Número de pessoas não pode ser menor ou igual a zero — deve gerar erro
  - Número de pessoas não pode ser maior que a capacidade da mesa — deve gerar erro
  - Se a mesa já estiver ocupada, exibir `"Erro: mesa já está ocupada."` e encerrar sem alterações
  - Caso contrário, registrar o cliente, marcar como ocupada e exibir `"Mesa {Numero} reservada para {nomeCliente} ({numeroPessoas} pessoas)."`
- Para liberar uma mesa:
  - Se a mesa já estiver disponível, exibir `"Erro: a mesa já está disponível."` e encerrar sem alterações
  - Caso contrário, limpar o cliente, marcar como disponível e exibir `"Mesa {Numero} liberada."`
- É possível consultar o status da mesa, informando número, capacidade e situação atual; se ocupada, o nome do cliente deve ser incluído

---

### O que deve ser demonstrado no programa

1. Duas mesas são criadas
2. O status inicial de uma mesa é exibido
3. Uma reserva válida é realizada
4. Uma tentativa de reserva na mesa já ocupada é feita; o erro deve ser exibido
5. O status atualizado da mesa é exibido
6. A mesa é liberada
7. Uma tentativa de liberar a mesa já disponível é feita; o erro deve ser exibido
8. O status final da mesa é exibido

---

### Saída esperada (referência)

```
Mesa 5 | Capacidade: 4 | Disponível
Mesa 5 reservada para Carlos (3 pessoas).
Erro: mesa já está ocupada.
Mesa 5 | Capacidade: 4 | Ocupada por: Carlos
Mesa 5 liberada.
Erro: a mesa já está disponível.
Mesa 5 | Capacidade: 4 | Disponível
```

---

### Critérios de avaliação

| Critério                   | O que será observado                                                                             |
| -------------------------- | ------------------------------------------------------------------------------------------------ |
| Encapsulamento             | Campos privados acessados via propriedades somente leitura; estado e nome do cliente protegidos  |
| Controle de estado         | Métodos de reserva e liberação controlam corretamente o estado da mesa                           |
| Erros técnicos             | `ArgumentException` lançada para nome vazio, número de pessoas inválido ou acima da capacidade   |
| Erros de negócio           | Reserva em mesa ocupada e liberação de mesa disponível exibem mensagem no console sem lançar exceção |

---