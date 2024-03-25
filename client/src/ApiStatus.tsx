import Loading from "./assets/spinner.gif";

type ApiStatus = {
  status: "success" | "error" | "pending";
};

export const ApiStatus = ({ status }: ApiStatus) => {
  switch (status) {
    case "error":
      return <div>Error communicating with the backend data</div>;
    case "pending":
      return <img src={Loading} alt="Loading ..." />;
    default:
      throw Error("Unknown API state");
  }
};
