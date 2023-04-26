import {
  createStyles,
  SegmentedControl,
  SegmentedControlItem,
} from '@mantine/core';
import { Colors } from '../../styles/colors';
import { SegmentItem } from './SegmentItem';
import InspektoLogo from '../../art/InspektoLogo.png';
import { ResumeCardType } from './enums';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor:
      theme.colorScheme === 'dark' ? theme.colors.dark[6] : theme.white,
  },

  control: {
    border: '0 !important',
  },

  label: {
    color: `${Colors.MAUVE}`,
    '&, &:hover': {
      '&[data-active]': {
        color: Colors.LIGHT_PURPLE,
      },
    },
  },
}));

interface SegmentControlProps {
  segmentItems: SegmentedControlItem[];
  setActive: (value: ResumeCardType) => void;
}
export const SegmentControl = ({
  segmentItems,
  setActive,
}: SegmentControlProps) => {
  const onChange = (value: string) => {
    setActive(value as ResumeCardType);
  };
  const { classes } = useStyles();
  return (
    <SegmentedControl
      orientation="vertical"
      radius="xl"
      size="md"
      data={segmentItems}
      onChange={onChange}
      classNames={classes}
    />
  );
};
