# Mayk
treinamento

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exemplo de Formulário</title>
</head>
<body>

    <h1>Crie sua Conta</h1>

    <form action="/enviar-dados" method="POST">
        
        <div>
            <label for="nome">Nome Completo:</label>
            <input type="text" id="nome" name="nome" required>
        </div>

        <br>

        <div>
            <label for="email">E-mail:</label>
            <input type="email" id="email" name="email" required>
        </div>

        <br>

        <div>
            <button type="submit">Enviar Cadastro</button>
        </div>

    </form>
    </body>
</html>

