import "./Logo.css";
import { LogoProps } from "../../types/logo";

export const Logo = ({ helperClass }: LogoProps) => {
  return (
    <img
      className={helperClass ? "helperClass" : "Logo"}
      src="../../../public/LIH-modern-logo.svg"
      alt="LIH Modern - Logo"
    />
  );
};
