import { Button } from '@mantine/core';

interface TopBarButtonProps {
  text: string;
  icon: React.ReactNode;
  color: string;
  link: string;
  isMobile: boolean;
}
const TopBarButton = ({
  text,
  icon,
  color,
  link,
  isMobile,
}: TopBarButtonProps) => {
  return isMobile ? (
    <Button
      component="a"
      target="_blank"
      rel="noopener noreferrer"
      href={link}
      color={color}>
      {icon}
    </Button>
  ) : (
    <Button
      component="a"
      target="_blank"
      rel="noopener noreferrer"
      href={link}
      color={color}
      leftIcon={icon}>
      {text}
    </Button>
  );
};

export default TopBarButton;
