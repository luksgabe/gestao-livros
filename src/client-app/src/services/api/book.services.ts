import { BOOK_ENDPOINTS } from "../../constants/services";
import { Api } from "../../providers";

const getAll = () => Api.get(`/${BOOK_ENDPOINTS.BASE}`);

export const BookService = {
    getAll,
}