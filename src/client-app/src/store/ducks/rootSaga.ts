import { all, AllEffect, ForkEffect, takeLatest } from "redux-saga/effects";
import { BooksTypes } from "./Books/types";
import { load } from "./Books/sagas";

export default function* rootSaga(): Generator<AllEffect<ForkEffect<never>>> {
    return yield all([takeLatest(BooksTypes.LOAD_REQUEST, load)]);
}
  