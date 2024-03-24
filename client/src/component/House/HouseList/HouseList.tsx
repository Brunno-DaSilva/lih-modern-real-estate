import { useEffect, useState } from "react";
import { House } from "../../../types/house";
import { config } from "../../../config";

const HouseList = () => {
  const [houses, setHouses] = useState<House[]>([]);

  useEffect(() => {
    const fetchAllHouses = async () => {
      const response = await fetch(`${config.BASE_API_URL}/houses`);
      const houses = await response.json();
      setHouses(houses);
    };
    fetchAllHouses();
  }, []);

  return (
    <div>
      <div className="row mb-2">
        <h5 className="themeFontColor text-center">
          Houses currently on the market
        </h5>
      </div>
      <table className="table table-hover">
        <thead>
          <tr>
            <th>Address</th>
            <th>City</th>
            <th>ZipCode</th>
            <th>Country</th>
            <th>Asking Price</th>
          </tr>
        </thead>
        <tbody>
          {houses &&
            houses.map((h: House) => (
              <tr key={h.id}>
                <td>{h.address}</td>
                <td>{h.city}</td>
                <td>{h.zipCode}</td>
                <td>{h.country}</td>
                <td>{h.price}</td>
              </tr>
            ))}
        </tbody>
      </table>
    </div>
  );
};

export default HouseList;
