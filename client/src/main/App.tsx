import HouseList from "../component/House/HouseList/HouseList";
import "./App.css";
import Header from "./Header/Header";

function App() {
  return (
    <>
      <div className="App">
        <Header subtitle="Modern Real Estate" />
        <HouseList />
      </div>
    </>
  );
}

export default App;
