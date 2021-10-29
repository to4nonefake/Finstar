import { configureStore } from '@reduxjs/toolkit';
import RecordsReducer from './recordsReducer';

export const store = configureStore({
  reducer: {
    recordsReducer: RecordsReducer,
  },
});
