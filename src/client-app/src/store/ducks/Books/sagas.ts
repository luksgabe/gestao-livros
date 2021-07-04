import { AxiosResponse } from "axios";
import { call, put } from "redux-saga/effects";
import api from "../../../services/api";
import { loadSuccess, loadFailure } from "./action";
import { Book } from './types';

export function* load() {
    try {
      const response: AxiosResponse<Book[]> = yield call(api.get, "book");
      console.log(response);
      yield put(loadSuccess(response.data));
    } catch (err) {
      yield put(loadFailure());
    }
  }
  