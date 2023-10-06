using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cleiteam.Data.Seeds
{
    public static class TipoOcorrenciaSeeds
    {
        public static void TipoOcorrenciaSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoOcorrencia>().HasData(
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA0"), "Iluminação Pública"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA1"), "Estradas e Tráfego"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA2"), "Transporte Público"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA3"), "Coleta de Lixo e Reciclagem"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA4"), "Manutenção de Parques e Praças"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA5"), "Abastecimento de Água"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA6"), "Saneamento Básica"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA7"), "Serviços de Emergência"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA8"), "Serviços de Saúde"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA9"), "Assistência Social"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4218-9ABB-792C2B979EA0"), "Atendimento ao Cliente"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4228-9ABB-792C2B979EA0"), "Questões Ambientais"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4238-9ABB-792C2B979EA0"), "Problemas de Segurança"),
                new TipoOcorrencia(Guid.Parse("B8E6CD20-4268-4248-9ABB-792C2B979EA0"), "Outras Preocupações Cidadãs")
                );

            modelBuilder.Entity<SubtipoOcorrencia>().HasData(
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA0"), "Postes de luz danificados"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA0"), "Lâmpadas de rua queimadas ou piscando"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA0"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA1"), "Buracos nas estradas"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA1"), "Sinalização inadequada ou ausente"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA1"), "Problemas de congestionamento de tráfego"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA1"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA2"), "Atrasos ou interrupções nos serviços de transporte público"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA2"), "Veículos sujos ou danificados"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA2"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA3"), "Coleta irregular de lixo"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA3"), "Recipientes de reciclagem danificados"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA3"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA4"), "Postes de luz danificados"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA4"), "Lampadas de rua queimadas ou piscando"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA4"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA5"), "Vazamentos de água visíveis"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA5"), "Problemas com o abastecimento de água potável"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA5"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA6"), "Problemas com esgoto ou drenagem"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA6"), "Entupimentos ou refluxo de esgoto"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA6"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA7"), "Iluminação Pública"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA7"), "Postes de luz danificados"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA7"), "Lâmpadas de rua queimadas ou piscando"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA7"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA8"), "Problemas nos hospitais públicos ou clínicas de saúde"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA8"), "Falhas na distribuição de vacinas ou medicamentos"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA8"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA9"), "Problemas com abrigos ou programas de assistência a pessoas em situação de rua"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4208-9ABB-792C2B979EA9"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4218-9ABB-792C2B979EA0"), "Dificuldades para entrar em contato com os órgãos governamentais"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4218-9ABB-792C2B979EA0"), "Respostas lentas a reclamações ou pedidos de assistência"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4218-9ABB-792C2B979EA0"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4228-9ABB-792C2B979EA0"), "Poluição do ar ou da água"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4228-9ABB-792C2B979EA0"), "Descarte inadequado de resíduos"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4228-9ABB-792C2B979EA0"), "Outros"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4238-9ABB-792C2B979EA0"), "Zonas perigosas ou locais com alto índice de criminalidade"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4228-9ABB-792C2B979EA0"), "Necessidade de melhorias na iluminação de áreas públicas para a segurança dos cidadãos"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4248-9ABB-792C2B979EA0"), "Ruído excessivo"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4248-9ABB-792C2B979EA0"), "Falta de estacionamento público"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4248-9ABB-792C2B979EA0"), "Problemas com transporte de animais de estimação ou controle de pragas"),
                new SubtipoOcorrencia(Guid.NewGuid(), Guid.Parse("B8E6CD20-4268-4248-9ABB-792C2B979EA0"), "Outros")
                );
        }
    }
}