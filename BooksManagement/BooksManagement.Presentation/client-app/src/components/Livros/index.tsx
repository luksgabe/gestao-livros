import * as React from 'react';


const Livros = () => (
    <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
            <tr>
                <th>Título</th>
                <th>Autor</th>
                <th>Gêneros</th>
                <th>Data Cadastro</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th>Star Wars Marcas da guerra</th>
                <th>Jorge Lucas</th>
                <th>Ação, Ficção cientifica</th>
                <th>26/09/2020</th>
            </tr>
            <tr>
                <th>Star Wars Marcas da guerra</th>
                <th>Jorge Lucas</th>
                <th>Ação, Ficção cientifica</th>
                <th>26/09/2020</th>
            </tr>
        </tbody>
    </table>
)

export default Livros;