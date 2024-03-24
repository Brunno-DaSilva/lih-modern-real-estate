import { Logo } from "../../component/Logo/Logo";
import "./Header.css";

type Header = {
  subtitle: string;
};

const Header = ({ subtitle }: Header) => {
  return (
    <header className="header">
      <div>
        <Logo />
      </div>
      <div>{subtitle}</div>
    </header>
  );
};

export default Header;
