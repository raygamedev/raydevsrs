import React from 'react';
import { ActionButton } from '../ActionButton/ActionButton';
import styled from '@emotion/styled';

const Container = styled.div`
  border: 3px;
  border-color: #1a1a1a;
  display: flex;
  justify-content: space-around;
  align-items: center;
  flex-direction: row;
`;

const ButtonsContainer = styled.div`
  display: flex;
  gap: 10px;
  justify-content: space-between;
  align-items: center;
  flex-direction: row;
`;

const Title = styled.div`
  font-family: 'Retro';
  font-size: 1.5rem;
  font-weight: 600;
  color: #1a1a1a;
`;

export const TopBar = () => {
  return (
    <Container>
      <Title>Raydevs</Title>
      <ButtonsContainer>
        <ActionButton onClick={() => console.log('lol')} text="pleb" variant="light" />
        <ActionButton onClick={() => console.log('lol')} text="pleb" variant="light" />
        <ActionButton onClick={() => console.log('lol')} text="pleb" variant="light" />
        <ActionButton onClick={() => console.log('lol')} text="plib" variant="light" />
      </ButtonsContainer>
    </Container>
  );
};
