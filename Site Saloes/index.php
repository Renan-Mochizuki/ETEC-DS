<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Salões</title>
    <link rel="icon" type="image/x-icon" href="img/favicon.ico">
    <link rel="stylesheet" type="text/css" href="css/indexcss.css"> 
</head>
<body>
<div id="fundo">
<div id="container">
<h1>Salões</h1>
<?php
    $host = "localhost";
    $user = "root";
    $pass = "root";
    $database = "bd_comercio_pw";

    $conexao = mysqli_connect($host,$user,$pass,$database)
    or die ("Conexão com o banco de dados mal sucedida");

    $infosalao = mysqli_query($conexao, "select * from salao");
        if(!$infosalao){
            die('Query Inválida: ' . mysqli_query($conexao));
        }
    $infoservico = mysqli_query($conexao, "select * from servico");
        if(!$infoservico){
            die('Query Inválida: ' . mysqli_query($conexao));
        }
    mysqli_close($conexao);

    $xml = '<?xml version="1.0" encoding="ISO-8859-1"?>';
    $xml .= '<array>';
    $xml .= '<comercio>';

    while($dadossalao=mysqli_fetch_array($infosalao)){
        $xml .= '<salao>';
        $xml .= '<salao_id>'.$dadossalao['salao_id'].'</salao_id>';
        $xml .= '<salao_nome>'.$dadossalao['salao_nome'].'</salao_nome>';
        $xml .= '<salao_endereco>'.$dadossalao['salao_endereco'].'</salao_endereco>';
        $xml .= '<salao_telefone>'.$dadossalao['salao_telefone'].'</salao_telefone>';
        $xml .= '<salao_email>'.$dadossalao['salao_email'].'</salao_email>';
        $xml .= '</salao>';
    }
    while($dadosservico=mysqli_fetch_array($infoservico)){
        $xml .= '<servico>';
        $xml .= '<servico_id>'.$dadosservico['servico_id'].'</servico_id>';
        $xml .= '<servico_nome>'.$dadosservico['servico_nome'].'</servico_nome>';
        $xml .= '<servico_valor>'.$dadosservico['servico_valor'].'</servico_valor>';
        $xml .= '<fk_salao_id>'.$dadosservico['fk_salao_id'].'</fk_salao_id>';
        $xml .= '</servico>';
    }
    $xml .= '</comercio>';
    $xml .= '</array>';

    $file = fopen('xml/bancoxml.xml', 'w+') or die("Não foi possível abrir o arquivo!");
    fwrite($file, $xml);
    fclose($file);
    echo "<p class='mensagem'>O Documento XML foi criado!</p> <a class='mensagem' href='xml/bancoxml.xml'>Clique para ver o XML</a>";

    $link = "xml/bancoxml.xml";
    $info = simplexml_load_file($link) -> comercio;
    echo "<div id='flex'>";
    foreach ($info -> salao as $salao){
        $id = trim($salao -> salao_id);
        
        echo "<div class='salao'>";
        echo "<p id='nome'>".utf8_decode($salao -> salao_nome)."</p>";
        echo "<hr>";
        echo "<img class='icone' src='img/pin.png'> <p class='atributo'>Endereço:</p> ".utf8_decode($salao -> salao_endereco)."<br>";
        echo "<img class='icone' src='img/telephone.png'> <p class='atributo'>Telefone:</p> ".utf8_decode($salao -> salao_telefone)."<br>";
        echo "<img class='icone' src='img/email.png'> <p class='atributo'>Email:</p> ".utf8_decode($salao -> salao_email)."<br>";
        ?>
        <table>
            <tr>
                <th>Serviços</th>
                <th>Valor</th>
            </tr>
        <?php
        foreach ($info -> servico as $servico){
            $fk = trim($servico -> fk_salao_id);
            if($id === $fk){
                echo "<tr>";
                echo "<td id='servico'>".utf8_decode($servico -> servico_nome)."</td>";
                echo "<td id='valor'>".utf8_decode($servico -> servico_valor)."</td>";
                echo "</tr>";
            } 
        }
        echo "</table>";
        echo "</div>";
    }
    echo "</div>";
?>
</div>
</div>
</body>
</html>