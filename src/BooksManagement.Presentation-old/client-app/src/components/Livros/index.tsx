import React, { Component } from 'react';
import { connect } from "react-redux";
import { bindActionCreators, Dispatch } from "redux";
import * as BooksActions from "../../store/ducks/Books/action";
import { ApplicationState } from "../../store";
import { Book } from '../../store/ducks/Books/types';

interface StateProps {
    books: Book[];
}

interface DispatchProps {
    loadRequest(): void;
}

type Props = StateProps & DispatchProps;


class Livros extends Component<Props> {

    componentDidMount() {        
        const { loadRequest } = this.props;
        loadRequest();
    }

    render() {

        const renderDataTable = (books: Book[]) => {
            debugger;
            if(books && books.length > 0) {
                return (
                    books.map((book: Book) => (
                        <tr key={book.id}>
                            <td>{book.title}</td>
                            <td>{book.author ?  book.author.name : 'Indefinido'}</td>
                            <td>{'Indefinido'}</td>
                            <td>{book.createdAt}</td>
                        </tr>
                    ))
                )
            } else {
                return (
                    <tr>
                        <td colSpan={4} align="center">Nenhum dado encontrado</td>
                    </tr>
                )
            }
        }

        const { books } = this.props;
        return (
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
                    {renderDataTable(books)}
                </tbody>
            </table>
        );
    }
}

const mapStateToProps = (state: ApplicationState) => ({
    books: state.books.data,
});
    
const mapDispatchToProps = (dispatch: Dispatch) =>
  bindActionCreators(BooksActions, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(Livros);