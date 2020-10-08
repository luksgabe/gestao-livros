import { all, takeLatest } from "redux-saga/effects";
import { BooksTypes } from "./Books/types";
import { load } from "./Books/sagas";

export default function* rootSaga() {
    return yield all([takeLatest(BooksTypes.LOAD_REQUEST, load)]);
}
  