interface CardProps {
  url: string;
  address: string;
}

const Card = ({ url, address }: CardProps) => {
  return (
    <div className="Card">
      <div className="Card__img">
        <img src={url} alt={address} />
      </div>
      <div className="Card__info"></div>
    </div>
  );
};

export default Card;
