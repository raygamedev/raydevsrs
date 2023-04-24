import React from 'react';
import { Global } from '@mantine/core';

export const Fonts = () => {
  return (
    <Global
      styles={[
        {
          '@font-face': {
            fontFamily: 'Retro',
            src: `url("../public/retro_computer.ttf") format('opentype')`,
            fontStyle: 'normal',
            fontWeight: 'normal',
          },
        },
      ]}
    />
  );
};
