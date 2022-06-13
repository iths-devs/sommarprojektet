import React, { FC } from "react";
import logo from "./logo.svg";
import SimpleGet from "./Components/SimpleGetRequestTemplate";
import "./App.css";

const App: FC = () => {
  return (
    <div className="App">
      <SimpleGet />
    </div>
  );
};

export default App;
