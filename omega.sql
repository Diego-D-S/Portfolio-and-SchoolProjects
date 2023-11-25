-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2023 at 08:23 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `omega`
--

-- --------------------------------------------------------

--
-- Table structure for table `fornecedores`
--

CREATE TABLE `fornecedores` (
  `fornecedor` varchar(150) NOT NULL,
  `tipo` varchar(30) NOT NULL,
  `contato` varchar(200) NOT NULL,
  `fone` varchar(50) NOT NULL,
  `ramal` varchar(30) NOT NULL,
  `cpf` varchar(60) NOT NULL,
  `rg` varchar(60) NOT NULL,
  `cgc_cnpj` varchar(70) NOT NULL,
  `IE` varchar(70) NOT NULL,
  `data_n` varchar(20) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `cep` varchar(40) NOT NULL,
  `endereco` varchar(300) NOT NULL,
  `numero` varchar(20) NOT NULL,
  `pais` varchar(150) NOT NULL,
  `cidade` varchar(300) NOT NULL,
  `bairro` varchar(300) NOT NULL,
  `estado` varchar(300) NOT NULL,
  `fone_2` varchar(50) NOT NULL,
  `fone_3` varchar(50) NOT NULL,
  `fax` varchar(50) NOT NULL,
  `email` varchar(70) NOT NULL,
  `site` varchar(120) NOT NULL,
  `observacao` varchar(1000) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `fornecedores`
--

INSERT INTO `fornecedores` (`fornecedor`, `tipo`, `contato`, `fone`, `ramal`, `cpf`, `rg`, `cgc_cnpj`, `IE`, `data_n`, `sexo`, `cep`, `endereco`, `numero`, `pais`, `cidade`, `bairro`, `estado`, `fone_2`, `fone_3`, `fax`, `email`, `site`, `observacao`) VALUES
('HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', 'Pessoa Jurídica', 'Abby', '+86 15986679132', '-', '-', '-', '-', '-', '-', 'F', '-', 'Room, Dingcheng International Building', '2607', 'China', 'Shenzhen', '-', 'Futian', '-', '-', '-', '-', '-', 'Nenhuma.'),
('M.J.CO.LTD', 'Pessoa Jurídica', 'M. J.', '+86 -13713895188', '-', '-', '-', '-', '-', '-', 'M', '-', '2th Floor, SEG Plaza, Shennan Zhong Rad', '29622', 'China', 'Shenzhen', '-', 'Futian District', '-', '-', '-', '-', '-', 'Nenhuma.'),
('Shenzhen Eshinede Technology Co.,Ltd.', 'Pessoa Jurídica', 'Bonnie Liu', '+86 -18229769929', '-', '-', '-', '-', '-', '-', 'M', '-', 'South Shaping Road,Jixia Village,Buji Town', '112', 'China', 'Shenzhen', '-', 'Longgang District', '-', '-', '-', '-', '-', 'Nenhuma.'),
('Global Alliance Science and technology LIMITED ', 'Pessoa Jurídica', 'Jane', '+8615818643585', '-', '-', '-', '-', '-', '-', 'M', '-', 'Room M, longsheng commercial Building, heping Road', '-', 'China', 'Shenzhen', '-', 'Longhua  Dist.', '-', '-', '-', '-', '-', 'Nenhuma.'),
('Hexagonal Produtos & Cia', 'Pessoa Jurídica', 'Roberto', '(+12)3458-7834', '35', '245.235.554-64', '25.325.456-8', '135478951248-64', '54784125', '12/02/1980', 'M', '2341545', 'Rua Astronautas', '245', 'Brasil', 'São Paulo', 'Jd Paulista', 'São Paulo', '4567-7854', '-', '-', 'roberto@hotmail.com', 'www.hexagonal.com.br', 'Nenhuma.'),
('Cartonagem Jacareí Ltda.', 'Pessoa Jurídica', 'Letácio L. Souza', '(12) 3953-3044 ', '-', '-', '-', '-', '-', '-', 'M', '12328-300', 'Av. Dr.  Adhemar Pereira de Barros', '148', 'Brasil', 'Jacareí', 'Jardim Sta. Maria', 'SP', '-', '-', '-', 'cartonagemj@uol.com.br', 'www.cartonagemjacarei.com.br', 'Fornecedor de Embalagens em papelão'),
('QUARIS PAPÉIS E PAPELÃO IND E COM LTDA - EPP', 'Pessoa Jurídica', 'JERUSA ALENCAR', '(12) 3931 6730', '-', '-', '-', '13.148.016/0001-98', '645.313.430.110', '-', 'M', '12239-020', 'RUA FRANCISCO ROSA MARQUÊS', '545', 'Brasil', 'SÃO JOSÉ DOS CAMPOS', 'MORUMBI', 'SP', '-', '-', '-', 'VENDAS01@QUARIS.COM.BR', 'www.quaris.com.br', 'Fornecedor de Embalagens'),
('Envelopack Indústria de Embalagens Especiais', 'Pessoa Jurídica', 'Denise Silva', '(11) 2936-7086', '-', '-', '-', '03.133.842/0001-00', '148448067113', '-', 'M', '04367-000', 'Rua Carlo Carra ', '756', 'Brasil', 'São Paulo', 'Vila Santa Catarina', 'SP', '-', '-', '-', 'orcamento@envelopack.com.br', 'www.envelopack.com.br', 'Fornecedor de Embalagens'),
('General Noli do Brasil Ltda', 'Pessoa Jurídica', 'Juliana Fernandes', '(19) 37946060', '-', '-', '-', '04.484.098/0001-50', '235.154.587.469', '-', 'F', '13025-240', 'Rua Antonio Lapa', '178', 'Brasil', 'Campinas', 'Cambui', 'SP', '-', '-', '-', 'juliana.fernandez@generalnoli.com', '-', 'Logistíca'),
('CSG Assessoria em Comércio Exterior', 'Pessoa Jurídica', 'Sérgio Luis Dias Piedade', '(13)35002300', '-', '-', '-', '15.123.254./0001-25', '125.854.965.753', '-', 'M', '11013-010', 'Praça da República', '87', 'Brasil', 'Santos', 'Centro', 'SP', '-', '-', '-', 'piedade@carlossouto.com.br', '-', 'Desembaraço Aduaneiro'),
('Felix Eletrônicos', 'Pessoa Jurídica', 'Felix Tadeu Marques', '(+12) 3945-6987', '7', '254.698.654.25', '65.654.658-8', '547813', 'Não tem.', '22/01/1999', 'M', '1224785', 'Rua Barão Vila Lobos', '265', 'Brasil', 'São José dos Campos', 'Jd. Colorado', 'São Paulo', '(+12) 4578-9854', 'Não tem.', 'Não tem.', 'felix@exemplomail.com', 'www.comercioonline.com.br', 'Nenhuma.');

-- --------------------------------------------------------

--
-- Table structure for table `pedidos`
--

CREATE TABLE `pedidos` (
  `numero` int(20) NOT NULL,
  `pedido` varchar(1000) NOT NULL,
  `data_p` varchar(15) NOT NULL,
  `hora_p` varchar(20) NOT NULL,
  `usuario` varchar(25) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `pedidos`
--

INSERT INTO `pedidos` (`numero`, `pedido`, `data_p`, `hora_p`, `usuario`) VALUES
(1, 'Cod: 1 - Prod: Arduino Uno R3 + Cabo Usb Tutorial Em Português P/ Robotica - Adicionado: 600\r\n', '23/01/2017', '19:56:14', 'adm'),
(2, 'Cod: 2 - Prod: Jumper Macho Para Macho 65pcs Fio Arduíno Para Mega E Uno - Adicionado: 50\r\n', '23/01/2017', '19:57:02', 'adm'),
(3, 'Cod: 1 - Prod: Arduino Uno R3 + Cabo Usb Tutorial Em Português P/ Robotica - Adicionado: 10\r\nCod: 2 - Prod: Jumper Macho Para Macho 65pcs Fio Arduíno Para Mega E Uno - Adicionado: 40\r\nCod: 3 - Prod: Fonte Regulável Xl6009 Dc-dc Step-up Boost Para Arduino Pic - Adicionado: 10\r\n', '23/01/2017', '19:59:01', 'adm'),
(4, 'Cod: 6    Prod: Motor Passo Arduino 28byj-48 5v Automação Pic Raspberry Pi    Retirado: 200\r\nCod: 9    Prod: Kit Chassi 2 Rodas Robótica Robô Projeto Arduino    Retirado: 10\r\n', '23/01/2017', '20:53:58', 'adm'),
(5, 'Cod: 5 - Prod: Roda + Pneu + Motor Dc 3 A 6v Com Redução Robotica Arduino - Adicionado: 20\r\nCod: 7 - Prod: Sensor Ultra Sonico De Distância Hc-sr04 Shield Arduino - Adicionado: 15\r\nCod: 1 - Prod: Arduino Uno R3 + Cabo Usb Tutorial Em Português P/ Robotica - Adicionado: 40\r\n', '26/01/2017', '16:09:33', 'Marcos'),
(6, 'Cod: 56 - Prod: Micro Ventilador Com Rolamento 60x60x25 12v 0,2a Fan Cooler - Adicionado: 10\r\nCod: 18 - Prod: Micro Servo Motor Tower Pro 9g Sg90 Com Acessórios Arduino - Adicionado: 10\r\nCod: 23 - Prod: Micro Ventilador 80x80x25 Fan Cooler 12v 0,17a Mini 80mm  - Adicionado: 10\r\n', '24/11/2023', '19:56:44', 'adm'),
(7, 'Cod: 5    Prod: Roda + Pneu + Motor Dc 3 A 6v Com Redução Robotica Arduino    Retirado: 563\r\n', '25/11/2023', '16:18:21', 'adm');

-- --------------------------------------------------------

--
-- Table structure for table `produtos`
--

CREATE TABLE `produtos` (
  `codigo` int(11) NOT NULL,
  `descricao` varchar(150) NOT NULL,
  `ala` varchar(15) NOT NULL,
  `prateleira` varchar(15) NOT NULL,
  `fornecedor` varchar(150) NOT NULL,
  `custo_c` varchar(20) NOT NULL,
  `custo_v` varchar(20) NOT NULL,
  `garantia` varchar(15) NOT NULL,
  `qtd_minima` int(15) NOT NULL,
  `estoque` int(15) NOT NULL,
  `observacoes` varchar(1000) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `produtos`
--

INSERT INTO `produtos` (`codigo`, `descricao`, `ala`, `prateleira`, `fornecedor`, `custo_c`, `custo_v`, `garantia`, `qtd_minima`, `estoque`, `observacoes`) VALUES
(1, 'Arduino Uno R3 + Cabo Usb Tutorial Em Português P/ Robotica', '-', 'A', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '12,00', '42,00', '90', 500, 940, 'Nenhuma.'),
(2, 'Jumper Macho Para Macho 65pcs Fio Arduíno Para Mega E Uno', '-', 'B', 'Global Alliance Science and technology LIMITED ', '6,50', '13,00', '90', 50, 1200, 'Nenhuma.'),
(3, 'Fonte Regulável Xl6009 Dc-dc Step-up Boost Para Arduino Pic', '1', 'A', 'Cartonagem Jacareí Ltda.', '4,99', '9,90', '90', 50, 20, 'Nenhuma.'),
(4, 'Regulador Tensao 3a Step-down Lm2596 Arduino Pic Raspberry', '1', 'B', 'Shenzhen Eshinede Technology Co.,Ltd.', '5,99', '9,99', '90', 50, 550, 'Nenhuma.'),
(5, 'Roda + Pneu + Motor Dc 3 A 6v Com Redução Robotica Arduino', '1', 'A', 'QUARIS PAPÉIS E PAPELÃO IND E COM LTDA - EPP', '11,50', '21,50', '90', 60, 57, 'Nenhuma.'),
(6, 'Motor Passo Arduino 28byj-48 5v Automação Pic Raspberry Pi', '2', 'A', 'CSG Assessoria em Comércio Exterior', '6,00', '9,80', '90', 50, 343, 'Nenhuma.'),
(7, 'Sensor Ultra Sonico De Distância Hc-sr04 Shield Arduino', '1', 'C', 'Hexagonal Produtos & Cia', '9,99', '15,99', '90', 70, 730, 'Nenhuma.'),
(8, 'Boia Sensor Nivel Lateral Magnetico Agua Arduino Aquário', '2', 'A', 'Hexagonal Produtos & Cia', '15,99', '18,99', '90', 80, 750, 'Nenhuma.'),
(9, 'Kit Chassi 2 Rodas Robótica Robô Projeto Arduino', '3', 'A', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '55,99', '81,90', '90', 40, 451, 'Nenhuma.'),
(10, 'Gabinete Caixa Case Box Arduino Uno De Acrílico Transparente', '1', 'C', 'CSG Assessoria em Comércio Exterior', '8,90', '16,99', '90', 50, 500, 'Nenhuma.'),
(11, 'Star Wars 3d Abajur Luminaria Led - O Despertar Da Força', '2', 'B', 'Cartonagem Jacareí Ltda.', '29,99', '52,90', '90', 80, 800, 'Nenhuma.'),
(12, 'Relé De Alta Potencia 12v 30a 250vca Arduino Ar Condicionado ', '2', 'A', 'Envelopack Indústria de Embalagens Especiais', '5,50', '9,90', '90', 60, 600, 'Nenhuma.'),
(13, 'Super Ímã Neodímio Extra Potente Aderente 10 Pçs Ø 10 X 4 Mm', '4', 'A', 'CSG Assessoria em Comércio Exterior', '10,99', '13,99', '90', 40, 500, 'Nenhuma.'),
(14, 'Motor Dc 5v 12v Alto Torque Alta Rotação Arduino E Robótica', '4', 'B', 'Shenzhen Eshinede Technology Co.,Ltd.', '5,99', '8,90', '90', 90, 800, 'Nenhuma.'),
(15, 'Driver Motor Passo A4988 P/ Placa Ramps Pololu Grbl Reprap', '1', 'C', 'M.J.CO.LTD', '2,99', '11,90', '90', 80, 800, 'Nenhuma.'),
(16, 'Sensor De Umidade De Solo Com Cabos Para Projetos Arduino', '4', 'A', 'General Noli do Brasil Ltda', '11,89', '25,99', '90', 80, 793, 'Nenhuma.'),
(17, 'Espelho Acrílico Seguro Quarto Do Bebê Neném Montessoriano', '1', 'C', 'General Noli do Brasil Ltda', '55,90', '74,58', '90', 50, 760, 'Nenhuma.'),
(18, 'Micro Servo Motor Tower Pro 9g Sg90 Com Acessórios Arduino', '1', 'C', 'Envelopack Indústria de Embalagens Especiais', '8,99', '12,90', '90', 50, 1010, 'Nenhuma.'),
(19, 'Cabo Auxiliar Para Radio Original Do Fiat Punto Frete Grátis', '2', 'B', 'QUARIS PAPÉIS E PAPELÃO IND E COM LTDA - EPP', '39,99', '49,99', '90', 50, 400, 'Nenhuma.'),
(20, 'Apm 4550 Apm4550 4550 Dip 8 Pinos Original Melhor Preço Ml', '1', 'B', 'Global Alliance Science and technology LIMITED ', '5,00', '10,00', '90', 50, 800, 'Nenhuma.'),
(21, 'Mini Motor Lg Vibra Vibracall Arduino Robotica Original ', '4', 'A', 'Global Alliance Science and technology LIMITED ', '5,60', '12,99', '90', 10, 1000, 'Nenhuma.'),
(22, 'Flat Cable Dvd H Buster Hbd 9540 9650 9510 9560 Frete Grátis', '2', 'C', 'M.J.CO.LTD', '35,99', '55,90', '90', 500, 4000, 'Nenhuma.'),
(23, 'Micro Ventilador 80x80x25 Fan Cooler 12v 0,17a Mini 80mm ', '1', 'A', 'Shenzhen Eshinede Technology Co.,Ltd.', '6,99', '12,90', '90', 10, 510, 'Nenhuma.'),
(24, 'Flat Cable Original Dvd Positron 6110 6111 6551 Frete Gratis', '2', 'C', 'Shenzhen Eshinede Technology Co.,Ltd.', '25,99', '50,00', '90', 90, 1000, 'Frete é Grátis.'),
(25, 'Cabo Usb Para Cd Original Fiat Connect E Ford My Connection', '1', 'C', 'Global Alliance Science and technology LIMITED ', '12,50', '35,90', '90', 10, 500, 'Nenhuma.'),
(26, 'Flat Original Dvd H Buster Hbd 9500 9550 9600 Frete Grátis', '2', 'C', 'CSG Assessoria em Comércio Exterior', '35,99', '52,90', '90', 40, 500, 'Nenhuma.'),
(27, 'Módulo Bluetooth Rs232 Para Arduino Hc-06 Robotica', '2', 'C', 'Cartonagem Jacareí Ltda.', '15,99', '25,50', '90', 50, 700, 'Nenhuma.'),
(28, 'Shield L293d Driver Ponte H Para Motor Arduino Mega E Uno ', '2', 'B', 'Cartonagem Jacareí Ltda.', '12,99', '24,49', '90', 50, 550, 'Região tem desconto de 3%.'),
(29, 'Hx711 24bits P/ Célula De Carga Peso Balança Sensor Arduino', '3', 'A', 'Shenzhen Eshinede Technology Co.,Ltd.', '12,99', '20,90', '90', 50, 420, 'Nenhuma.'),
(30, 'Arduino Mega 2560 R3 Cabo Usb Tutorial Em Português Robotica', '1', 'C', 'QUARIS PAPÉIS E PAPELÃO IND E COM LTDA - EPP', '55,90', '81,00', '90', 50, 800, 'Nenhuma.'),
(31, 'Flat Cable Pioneer Avh 3550 3580 Avh3580dvd Frete Grátis', '2', 'B', 'Global Alliance Science and technology LIMITED ', '35,90', '62,50', '90', 50, 800, 'Nenhuma.'),
(32, 'Cabo Flat Cable Dvd H Buster Hbd 9540 9650 9510 9560 Hbuster ', '2', 'A', 'CSG Assessoria em Comércio Exterior', '15,99', '41,50', '90', 20, 400, 'Nenhuma.'),
(33, 'Cabo Coaxial Cftv Flexível 4mm Bipolar 2 Vias 80% Malha 65m', '2', 'A', 'QUARIS PAPÉIS E PAPELÃO IND E COM LTDA - EPP', '5,99', '15,90', '90', 100, 1000, 'Nenhuma.'),
(34, 'Flat Cable Original Para Dvd H-buster Hbd-9500dvd Hbd-9550av', '3', 'C', 'Global Alliance Science and technology LIMITED ', '26,80', '48,50', '90', 10, 500, 'Nenhuma.'),
(35, 'Cabo Ami Usb Audi E Vw Adaptador Pen Drive Golf Jetta', '2', 'A', 'Shenzhen Eshinede Technology Co.,Ltd.', '40,00', '65,00', '90', 50, 1000, 'Nenhuma.'),
(36, 'Flat Cable Original Dvd Positron 6300 6700 Dtv Frete Gratis', '2', 'A', 'Shenzhen Eshinede Technology Co.,Ltd.', '26,99', '45,80', '90', 50, 800, 'Frete é Grátis.'),
(37, 'Cabo Flat Original Dvd Positron Sp6110 Sp6111 Sp6551 Sp6861', '1', 'C', 'CSG Assessoria em Comércio Exterior', '9,99', '15,99', '90', 500, 2500, 'Nenhuma.'),
(38, 'Espelho Decorativo Acrílico 1,24x0,62m Sala Quarto Grande', '2', 'C', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '250,00', '326,90', '90', 10, 200, 'Nenhuma.'),
(39, 'Driver Fonte Led 10w 90v / 260v Ip67 De 9 / 12v Prova D agua', '2', 'B', 'Shenzhen Eshinede Technology Co.,Ltd.', '5,99', '10,80', '90', 50, 700, 'Nenhuma.'),
(40, 'Espelho Borboleta Decorativo 5 Peças Acrílico 30/20/10/7,5cm', '2', 'B', 'General Noli do Brasil Ltda', '25,99', '37,90', '90', 50, 500, 'Nenhuma.'),
(41, 'Cabo Ami Mdi Mmi Iphone 5s 6 6s Vw Golf Jetta Audi A1 A3 A4 ', '2', 'B', 'Shenzhen Eshinede Technology Co.,Ltd.', '49,99', '63,90', '90', 80, 800, 'Nenhuma.'),
(42, 'Espelho Acrílico Grande Quarto Bebê Montessoriano 100x50cm', '3', 'C', 'M.J.CO.LTD', '105,90', '146,90', '90', 50, 800, 'Nenhuma.'),
(43, 'Flat Dvd H Buster Hbd 9540 9650 9510 9560 9760 Frete Grátis', '1', 'B', 'General Noli do Brasil Ltda', '25,90', '52,90', '90', 60, 900, 'Nenhuma.'),
(44, 'Cabo Auxiliar Ip-bus Aux Para Pioneer Mp3 Mp4 Ipod Promoção', '2', 'A', 'Hexagonal Produtos & Cia', '18,90', '22,90', '90', 40, 800, 'Nenhuma.'),
(45, '2 X Rodas + Pneus + Motor 3 A 6v + Redução Robotica Arduino ', '1', 'B', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '25,90', '55,90', '90', 60, 600, 'Nenhuma.'),
(46, 'Relé De Alta Potencia 12 Volts 30 Amperes 250vca Arduino Pic', '1', 'B', 'Global Alliance Science and technology LIMITED ', '5,90', '9,99', '90', 80, 800, 'Nenhuma.'),
(47, 'Célula Sensor De Carga Peso Com Case 50 Kg - Projeto Arduino ', '2', 'A', 'Shenzhen Eshinede Technology Co.,Ltd.', '12,99', '22,50', '90', 50, 800, 'Nenhuma.'),
(48, 'Flat Cable Original Para Dvd H-buster Hbd-9500dvd Hbd-9550av ', '2', 'B', 'Global Alliance Science and technology LIMITED ', '25,99', '52,50', '90', 50, 500, 'Nenhuma.'),
(49, 'Cabo Flat Cable Ucb Mods Ucb-dr170-dvd Ucb-dr171av Original', '3', 'A', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '15,99', '45,80', '90', 20, 400, 'Nenhuma.'),
(50, 'Sensor De Nivel Altura Agua Arduino Microcontrolador Aquário', '2', 'C', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '9,99', '15,99', '90', 40, 850, 'Nenhuma.'),
(51, 'Chicote Para Dvd Retrátil Pioneer Rabicho Cabo Conector Azul ', '2', 'B', 'Hexagonal Produtos & Cia', '25,99', '52,90', '90', 80, 800, 'Nenhuma.'),
(52, 'Cabo Auxiliar Cd Original Honda Fit Ex 2007 08 Frete Gratis', '1', 'A', 'Hexagonal Produtos & Cia', '39,90', '58,60', '90', 50, 740, 'Frete Grátis.'),
(53, 'Motor Dc 1,5v - 3v R140 / Motorzinho Ideal Arduino Pic E Etc\"', '1', 'B', 'Hexagonal Produtos & Cia', '15,99', '25,99', '90', 80, 800, 'Nenhuma.'),
(54, 'Chicote Dvd Pioneer Retratil Avh 5000 5100 5200 5450 6350 E+', '4', 'A', 'M.J.CO.LTD', '25,99', '53,60', '90', 50, 500, 'Nenhuma.'),
(55, '10 Capacitor Eletrolitico 2200uf X 25v Sam Young 105ºc', '4', 'B', 'Shenzhen Eshinede Technology Co.,Ltd.', '5,99', '10,00', '90', 50, 900, 'Nenhuma.'),
(56, 'Micro Ventilador Com Rolamento 60x60x25 12v 0,2a Fan Cooler', '4', 'A', 'Shenzhen Eshinede Technology Co.,Ltd.', '9,99', '15,50', '90', 200, 1483, 'Nenhuma.'),
(57, 'Roda Boba Robot Caster Esfera Arduino Raspberry Pi Galileo ', '4', 'B', 'Global Alliance Science and technology LIMITED ', '10,99', '15,90', '90', 50, 700, 'Nenhuma.'),
(58, 'Cabo Auxiliar Citroen C4 Pallas Peugeot 307 407 Kit Completo', '4', 'B', 'Global Alliance Science and technology LIMITED ', '25,99', '51,80', '90', 50, 700, 'Nenhuma.'),
(59, 'Motor De Passo 5v + Drive Uln2003 (stepper Motor) - Arduino ', '4', 'A', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '15,99', '19,00', '90', 60, 800, 'Nenhuma.'),
(60, 'Cabo Auxiliar Cd Original Linha Fiat Frete Grátis + Chaves', '4', 'B', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '15,99', '49,99', '90', 30, 800, 'Nenhuma.'),
(61, 'Cabo Auxiliar Citroen C4 Pallas Peugeot 307 407 Kit Completo ', '4', 'A', 'Global Alliance Science and technology LIMITED ', '15,99', '25,50', '90', 50, 800, 'Nenhuma.'),
(62, 'Cabo Coaxial Cftv Flexível 4mm Bipolar 2 Vias 80% Malha 50m', '3', 'B', 'Global Alliance Science and technology LIMITED ', '15,99', '20,00', '90', 90, 800, 'Nenhuma.'),
(63, 'Arduino Pro Mini Atmega328p 16mhz 5v 328', '3', 'A', 'Global Alliance Science and technology LIMITED ', '15,99', '18,99', '90', 50, 800, 'Nenhuma.'),
(64, 'Cabo Ami Usb Audi E Vw Adaptador Pen Drive Golf Jetta ', '3', 'A', 'HONGKONG  KUONGSHUN  ELECTRONIC LIMITED', '25,80', '49,90', '90', 80, 800, 'Nenhuma.'),
(65, 'Espelho Em Acrilico Decorativo Hexagonal Kit Com 10 Peças ', '2', 'A', 'Hexagonal Produtos & Cia', '25,99', '41,00', '90', 80, 800, 'Nenhuma.'),
(66, 'Suporte Skin Para Sensor Ultrassônico Hc-sr04 Sonar Arduino ', '1', 'C', 'Shenzhen Eshinede Technology Co.,Ltd.', '19,99', '50,60', '90', 50, 500, 'Nenhuma.'),
(67, 'Relé De Alta Potencia 24 Volts 30 Amperes 250vca Arduino Pic', '1', 'A', 'Shenzhen Eshinede Technology Co.,Ltd.', '19,99', '25,60', '90', 5, 80, 'Nenhuma.'),
(68, 'Flat Cable Pioneer Avh-p 5000 5050 5080 5100 5150 Cnq1956', '1', 'B', 'Shenzhen Eshinede Technology Co.,Ltd.', '19,99', '50,50', '90', 40, 400, 'Nenhuma.'),
(69, 'Step Down Dc-dc Lm2596 Fonte Ajustável Arduino Pic', '3', 'C', 'Shenzhen Eshinede Technology Co.,Ltd.', '5,99', '12,99', '90', 90, 900, 'Nenhuma.'),
(70, 'Motor Vibracall Arduino Original Lg Projetos Tcc Vibrador', '1', 'C', 'Shenzhen Eshinede Technology Co.,Ltd.', '5,99', '12,80', '90', 80, 800, 'Nenhuma.'),
(71, 'Arduino Uno Mega T-2', '2', 'B', 'Felix Eletrônicos', '19,99', '28,99', '90', 50, 1000, 'Nenhuma observação.');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario` varchar(25) NOT NULL,
  `senha` varchar(25) NOT NULL,
  `adm` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `senha`, `adm`) VALUES
('adm', '123', 'Sim'),
('Carol', '123', 'Não'),
('Marcos', '321', 'Sim'),
('Martha', '123', 'Sim'),
('Robson', '321', 'Não'),
('Tatiane', 'Senhadatatiane', 'Não');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD PRIMARY KEY (`fornecedor`);

--
-- Indexes for table `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `usuario` (`usuario`);

--
-- Indexes for table `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `fornecedor` (`fornecedor`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `numero` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `produtos`
--
ALTER TABLE `produtos`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
