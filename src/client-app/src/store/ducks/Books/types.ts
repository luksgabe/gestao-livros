import { Status } from '../Util/enums';
import { Author } from '../Authors/types';

export enum BooksTypes {
    LOAD_REQUEST = "@books/LOAD_REQUEST",
    LOAD_SUCCESS = "@books/LOAD_SUCCESS",
    LOAD_FAILURE = "@books/LOAD_FAILURE",
}

export interface Book {
    id: number;
    title: string;
    authorId: number;
    author: Author;
    createdAt: Date;
    updatedAt: Date;
    status: Status;
}

export interface BooksState {
    data: Book[];
    loading: boolean;
    error: boolean;
}