import { call, put } from "redux-saga/effects";
import api from "../../../services/api";
import { loadSuccess, loadFailure } from "./action";

export function* load() {
    try {
      const response = yield call(api.get, "book");
      console.log(response);
      yield put(loadSuccess(response.data));
    } catch (err) {
      yield put(loadFailure());
    }
  }
  