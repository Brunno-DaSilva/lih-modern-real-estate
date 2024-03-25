import { House } from "../types/house";
import { config } from "../config";
import { useQuery } from "@tanstack/react-query";
import axios, { AxiosError } from "axios";

const useFetchHouses = () => {
  return useQuery<House[], AxiosError>({
    queryKey: ["houses"],
    queryFn: () =>
      axios
        .get(`${config.BASE_API_URL}/houses`)
        .then((response) => response.data),
  });
};

export default useFetchHouses;
