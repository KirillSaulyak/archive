/** @type {import('next').NextConfig} */
const nextConfig = {
  images: {
    remotePatterns: [
      {
        protocol: "https",
        hostname: "example.com", // Хост внешнего источника
        port: "", // Порт, можно оставить пустым для стандартных
        pathname: "/images/**", // Путь к изображению или оставить /**
      },
    ],
  },
};

module.exports = nextConfig;
