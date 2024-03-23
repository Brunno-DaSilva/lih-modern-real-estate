import logo from "./LIH-MODERN-LOGO.png";
import "./Header.css";

const Header = () => {
  return (
    <header className="header">
      <div>
        <img src={logo} className="header__logo" alt="LIH-MODERN-LOGO" />
      </div>
    </header>
  );
};

export default Header;
