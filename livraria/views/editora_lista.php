<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel='stylesheet' type='text/css' media='screen' href='../css/bootstrap.css'>
    <link rel='stylesheet' type='text/css' media='screen' href='css/listas.css'>
    <script src="../js/bootstrap.js"></script>
    <title>Lista de editoras</title>
    <style>
      
.td_desc{
width: 900px;
}
    </style>
</head>
<body>
  <div id="background">
    <nav class="navbar navbar-expand-lg">
      <div class="container-fluid">
            <img src="../img/icon.png" alt="Bootstrap" width="40">
            <a class="navbar-brand" href="index.html">BookMaster</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class="navbar-toggler-icon"></span>
            </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
                <a class="nav-link active" aria-current="page" href="index.html">Home</a>
            </li>
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                  Cadastros
                </a>
                <ul class="dropdown-menu">
                  <li><a class="dropdown-item" href="livro_cad.php">Cadastrar livro</a></li>
                  <li><a class="dropdown-item" href="editora_cad.php">Cadastrar editora</a></li>
                  <li><a class="dropdown-item" href="categoria_cad.php">Cadastrar categoria</a></li>
                  <li><a class="dropdown-item" href="autor_cad.php">Cadastrar autor</a></li>
                </ul>
            </li>
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                  Checar listas
                </a>
              <ul class="dropdown-menu">
                <li><a class="dropdown-item" href="livro_lista.php">Lista de livros</a></li>
                <li><a class="dropdown-item" href="editora_lista.php">Lista de editoras</a></li>
                <li><a class="dropdown-item" href="categoria_lista.php">Lista de categorias</a></li>
                <li><a class="dropdown-item" href="autor_lista.php">Lista de autores</a></li>
              </ul>
            </li>
          </ul>
        </div>
      </div>
    </nav>
      <div class="titulo">
          <h1>Lista de editoras</h1>
      </div>
    <div id="container">
      <table border="1">
        <tr class="nomes_td">
          <td class="td_id">ID</td>
          <td class="td_desc">Descrição</td>
          <td class="td_alt">Alterar</td>
          <td class="td_ex">Excluir</td>
        </tr>
          <?php
            include("../bd/conexao.php");
            include("../controls/editora.php");
            $editoras=listar_editora($conexao);
            foreach ($editoras as $editora):
          ?>
        <tr class="variaveis">
          <td><?=$editora['id_editora'] ?></td>
          <td><?=$editora['descricao']?></td>
          <td><a href="editora_altera.php?id=<?=$editora['id_editora']?>">Alterar</a> </td>
          <td><a href="editora_exclui.php?id=<?=$editora['id_editora']?>">Excluir</a></td>
        </tr>
          <?php endforeach; ?>
      </table>
    </div>
  </div>
</body>
</html>