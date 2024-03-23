import logo from "./LIH-MODERN-LOGO.png";
import "./Header.css";

type Header = {
  subtitle: string;
};

const Header = ({ subtitle }: Header) => {
  return (
    <header className="header">
      <div>
        <img src={logo} className="header__logo" alt="LIH-MODERN-LOGO" />
      </div>
      <div>{subtitle}</div>
    </header>
  );
};

export default Header;
