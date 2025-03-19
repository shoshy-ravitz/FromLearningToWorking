import { combineReducers, configureStore } from "@reduxjs/toolkit";
import authSlice from "./authSlice";


const store = configureStore({
    reducer: combineReducers({
        auth: authSlice,
    }),
});

export type StoreType = ReturnType<typeof store.getState>

export default store