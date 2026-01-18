import './globals.css'
import type { Metadata } from 'next'
import { Inter } from 'next/font/google'

import NavBar from "@/components/MUI/movie/admin/navBars/NavBar/NavBar";
import Container from '@/components/MUI/movie/admin/containers/Container/Container';
import ReduxProvider from '@/components/providers/ReduxProvider';

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
          <ReduxProvider>
            {children}
          </ReduxProvider>
        </Container>
      </body>
    </html>
  )
}