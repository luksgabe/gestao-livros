import { useCallback, useState } from "react"
import { BookService } from "../services/api";

import { Book } from "../store/ducks/Books/types";

export const useBook = () => {
    const [books, setBooks] = useState<Book[]>();


    const getAll = useCallback(async () => {
        const { status, data } = await BookService.getAll();

        if(status != 200) throw Error();

        setBooks(data);
    }, [])
    
    return {
        books,
        getAll
    }
}