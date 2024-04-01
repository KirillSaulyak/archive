'use client'

import './globals.css'
import type { Metadata } from 'next'
import { Inter } from 'next/font/google'
import { Provider } from 'react-redux';

import store from '../components/store';
import NavBar from "../components/MUI/navBars/navBar";
import Container from '../components/MUI/containers/container';

const inter = Inter({ subsets: ['latin'] })

export const metadata: Metadata = {
  title: 'Archive',
  description: 'Made by Kirill',
}

export default function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <html lang="en">
      <body className={inter.className}>
        <Container>
          <NavBar />
          <Provider store={store}>
            {children}
          </Provider>
        </Container>
      </body>
    </html>
  )
}