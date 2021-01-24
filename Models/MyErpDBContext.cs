using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyErp.Models
{
    public partial class MyErpDBContext : DbContext
    {
        public MyErpDBContext()
        {
        }

        public MyErpDBContext(DbContextOptions<MyErpDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TCCplanning> TCCplannings { get; set; }
        public virtual DbSet<TCCplant> TCCplants { get; set; }
        public virtual DbSet<TCCplantPort> TCCplantPorts { get; set; }
        public virtual DbSet<TCCproduct> TCCproducts { get; set; }
        public virtual DbSet<TCPorder> TCPorders { get; set; }
        public virtual DbSet<TCustomer> TCustomers { get; set; }
        public virtual DbSet<TExplosion> TExplosions { get; set; }
        public virtual DbSet<TFacility> TFacilities { get; set; }
        public virtual DbSet<TMComponent> TMComponents  { get; set; }
        public virtual DbSet<TMPoprice> TMPoprices { get; set; }
        public virtual DbSet<TMPorder> TMPorders { get; set; }
        public virtual DbSet<TMRouting> TMRoutings { get; set; }
        public virtual DbSet<TMStorage> TMStorages { get; set; }
        public virtual DbSet<TMaterial> TMaterials { get; set; }
        public virtual DbSet<TPCareer> TPCareers { get; set; }
        public virtual DbSet<TPContract> TPContracts { get; set; }
        public virtual DbSet<TPCurric> TPCurrics { get; set; }
        public virtual DbSet<TPPay> TPPays { get; set; }
        public virtual DbSet<TPPresen> TPPresens { get; set; }
        public virtual DbSet<TPReview> TPReviews { get; set; }
        public virtual DbSet<TPTrain> TPTrains { get; set; }
        public virtual DbSet<TPerson> TPersons { get; set; }
        public virtual DbSet<TSPlanning> TSPlannings { get; set; }
        public virtual DbSet<TSProduct> TSProducts { get; set; }
        public virtual DbSet<TStorage> TStorages { get; set; }
        public virtual DbSet<TSuplier> TSupliers { get; set; }
        public virtual DbSet<TWccomponent> TWccomponents { get; set; }
        public virtual DbSet<TWorkCenter> TWorkCenters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=MyErpDB;user=SA;password=Debian19+");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TCCplanning>(entity =>
            {
                entity.HasKey(e => e.CplanId)
                    .HasName("PK__T_C_CPla__0600298F7F5C86EC");

                entity.ToTable("T_C_CPlanning");

                entity.Property(e => e.CplanId).HasColumnName("CPlanId");

                entity.Property(e => e.CplanCplantId).HasColumnName("CPlanCPlantId");

                entity.Property(e => e.CplanCprodId).HasColumnName("CPlanCProdId");

                entity.Property(e => e.CplanCustId).HasColumnName("CPlanCustId");

                entity.Property(e => e.CplanDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("CPlanDateFrom");

                entity.Property(e => e.CplanDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("CPlanDateTo");

                entity.Property(e => e.CplanFirmSt)
                    .HasMaxLength(55)
                    .HasColumnName("CPlanFirmSt");

                entity.Property(e => e.CplanQty).HasColumnName("CPlanQty");
            });

            modelBuilder.Entity<TCCplant>(entity =>
            {
                entity.HasKey(e => e.CplantId)
                    .HasName("PK__T_C_CPla__D296EB95D17C0126");

                entity.ToTable("T_C_CPlant");

                entity.Property(e => e.CplantId).HasColumnName("CPlantId");

                entity.Property(e => e.CplantAcct)
                    .HasMaxLength(225)
                    .HasColumnName("CPlantAcct");

                entity.Property(e => e.CplantAdAdit)
                    .HasMaxLength(225)
                    .HasColumnName("CPlantAdAdit");

                entity.Property(e => e.CplantAdCity)
                    .HasMaxLength(225)
                    .HasColumnName("CPlantAdCity");

                entity.Property(e => e.CplantAdCtry)
                    .HasMaxLength(4)
                    .HasColumnName("CPlantAdCtry");

                entity.Property(e => e.CplantAdStrt)
                    .HasMaxLength(225)
                    .HasColumnName("CPlantAdStrt");

                entity.Property(e => e.CplantCode)
                    .HasMaxLength(225)
                    .HasColumnName("CPlantCode");

                entity.Property(e => e.CplantCrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CPlantCrDate");

                entity.Property(e => e.CplantCtEdilog)
                    .HasMaxLength(100)
                    .HasColumnName("CPlantCtEDILog");

                entity.Property(e => e.CplantCtEmailLog)
                    .HasMaxLength(125)
                    .HasColumnName("CPlantCtEmailLog");

                entity.Property(e => e.CplantCtPhone)
                    .HasMaxLength(55)
                    .HasColumnName("CPlantCtPhone");

                entity.Property(e => e.CplantCtWeb)
                    .HasMaxLength(225)
                    .HasColumnName("CPlantCtWeb");

                entity.Property(e => e.CplantCustId).HasColumnName("CPlantCustId");

                entity.Property(e => e.CplantDeno)
                    .HasMaxLength(225)
                    .HasColumnName("CPlantDeno");

                entity.Property(e => e.CplantStDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CPlantStDate");

                entity.Property(e => e.CplantStatus)
                    .HasMaxLength(25)
                    .HasColumnName("CPlantStatus");
            });

            modelBuilder.Entity<TCCplantPort>(entity =>
            {
                entity.HasKey(e => e.PortId)
                    .HasName("PK__T_C_CPla__D859BF8F1E7BD4B1");

                entity.ToTable("T_C_CPlantPort");

                entity.Property(e => e.PortAcct).HasMaxLength(225);

                entity.Property(e => e.PortAdAdit).HasMaxLength(225);

                entity.Property(e => e.PortAdCity).HasMaxLength(225);

                entity.Property(e => e.PortAdCtry).HasMaxLength(4);

                entity.Property(e => e.PortAdStrt).HasMaxLength(225);

                entity.Property(e => e.PortCode).HasMaxLength(225);

                entity.Property(e => e.PortCplantId).HasColumnName("PortCPlantId");

                entity.Property(e => e.PortCrDate).HasColumnType("datetime");

                entity.Property(e => e.PortCtEdilog)
                    .HasMaxLength(100)
                    .HasColumnName("PortCtEDILog");

                entity.Property(e => e.PortCtEmailLog).HasMaxLength(125);

                entity.Property(e => e.PortCtPhone).HasMaxLength(55);

                entity.Property(e => e.PortDock).HasMaxLength(125);

                entity.Property(e => e.PortStDate).HasColumnType("datetime");

                entity.Property(e => e.PortStatus).HasMaxLength(25);
            });

            modelBuilder.Entity<TCCproduct>(entity =>
            {
                entity.HasKey(e => e.CprodId)
                    .HasName("PK__T_C_CPro__D996C459F7A6514D");

                entity.ToTable("T_C_CProduct");

                entity.Property(e => e.CprodId).HasColumnName("CProdId");

                entity.Property(e => e.CprodCplantId).HasColumnName("CProdCPlantId");

                entity.Property(e => e.CprodCrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CProdCrDate");

                entity.Property(e => e.CprodCustId).HasColumnName("CProdCustId");

                entity.Property(e => e.CprodDescInt)
                    .HasMaxLength(225)
                    .HasColumnName("CProdDescInt");

                entity.Property(e => e.CprodPoid).HasColumnName("CProdPOId");

                entity.Property(e => e.CprodRefInt)
                    .HasMaxLength(125)
                    .HasColumnName("CProdRefInt");

                entity.Property(e => e.CprodStatus)
                    .HasMaxLength(125)
                    .HasColumnName("CProdStatus");
            });

            modelBuilder.Entity<TCPorder>(entity =>
            {
                entity.HasKey(e => e.Cpoid)
                    .HasName("PK__T_C_POrd__733B0EE13FE41AE9");

                entity.ToTable("T_C_POrder");

                entity.Property(e => e.Cpoid).HasColumnName("CPOId");

                entity.Property(e => e.CpocplantId).HasColumnName("CPOCPlantId");

                entity.Property(e => e.CpocprodId).HasColumnName("CPOCProdId");

                entity.Property(e => e.Cpocurcy)
                    .HasMaxLength(25)
                    .HasColumnName("CPOCurcy");

                entity.Property(e => e.CpocustId).HasColumnName("CPOCustId");

                entity.Property(e => e.Cpodate)
                    .HasColumnType("datetime")
                    .HasColumnName("CPODate");

                entity.Property(e => e.CpodescEx)
                    .HasMaxLength(225)
                    .HasColumnName("CPODescEx");

                entity.Property(e => e.Cpopo)
                    .HasMaxLength(125)
                    .HasColumnName("CPOPO");

                entity.Property(e => e.Cpoprice).HasColumnName("CPOPrice");

                entity.Property(e => e.CporeferEx)
                    .HasMaxLength(125)
                    .HasColumnName("CPOReferEx");

                entity.Property(e => e.Cpostatus)
                    .HasMaxLength(25)
                    .HasColumnName("CPOStatus");
            });

            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__T_Custom__049E3AA9CB2EA140");

                entity.ToTable("T_Customer");

                entity.Property(e => e.CustAcct).HasMaxLength(225);

                entity.Property(e => e.CustAdAdit).HasMaxLength(225);

                entity.Property(e => e.CustAdCity).HasMaxLength(225);

                entity.Property(e => e.CustAdCtry).HasMaxLength(4);

                entity.Property(e => e.CustAdStrt).HasMaxLength(225);

                entity.Property(e => e.CustCode).HasMaxLength(225);

                entity.Property(e => e.CustCrDate).HasColumnType("datetime");

                entity.Property(e => e.CustCtBankAcc).HasMaxLength(225);

                entity.Property(e => e.CustCtEdifin)
                    .HasMaxLength(100)
                    .HasColumnName("CustCtEDIFin");

                entity.Property(e => e.CustCtEdilog)
                    .HasMaxLength(100)
                    .HasColumnName("CustCtEDILog");

                entity.Property(e => e.CustCtEmailFin).HasMaxLength(125);

                entity.Property(e => e.CustCtEmailLog).HasMaxLength(125);

                entity.Property(e => e.CustCtPhone).HasMaxLength(55);

                entity.Property(e => e.CustCtWeb).HasMaxLength(225);

                entity.Property(e => e.CustNif)
                    .HasMaxLength(10)
                    .HasColumnName("CustNIF");

                entity.Property(e => e.CustRasoc).HasMaxLength(125);

                entity.Property(e => e.CustStDate).HasColumnType("datetime");

                entity.Property(e => e.CustStatus).HasMaxLength(25);
            });

            modelBuilder.Entity<TExplosion>(entity =>
            {
                entity.HasKey(e => e.ExpId)
                    .HasName("PK__T_Explos__45B117E7E9263F57");

                entity.ToTable("T_Explosion");

                entity.Property(e => e.ExpRefer).HasMaxLength(125);

                entity.Property(e => e.ExpDescr).HasMaxLength(225);

                entity.Property(e => e.ExpsLevel).HasMaxLength(25);
            });
            
            modelBuilder.Entity<TFacility>(entity =>
            {
                entity.HasKey(e => e.FaId)
                    .HasName("PK__T_Facili__2FF65FF19E2D965D");

                entity.ToTable("T_Facility");

                entity.Property(e => e.FaAcct).HasMaxLength(225);

                entity.Property(e => e.FaCode).HasMaxLength(225);

                entity.Property(e => e.FaCrDate).HasColumnType("datetime");

                entity.Property(e => e.FaDescr).HasMaxLength(125);

                entity.Property(e => e.FaStDate).HasColumnType("datetime");

                entity.Property(e => e.FaStatus).HasMaxLength(25);

                entity.Property(e => e.FaType).HasMaxLength(25);
            });

            modelBuilder.Entity<TMComponent>(entity =>
            {
                entity.HasKey(e => e.CoId)
                    .HasName("PK__T_M_Comp__A25F3E2B8E4CCFA4");

                entity.ToTable("T_M_Component");

                entity.Property(e => e.CoStDate).HasColumnType("datetime");

                entity.Property(e => e.CoStat).HasMaxLength(125);
            });

            modelBuilder.Entity<TMPoprice>(entity =>
            {
                entity.HasKey(e => e.PrId)
                    .HasName("PK__T_M_POPr__A5021AAF0B449881");

                entity.ToTable("T_M_POPrice");

                entity.Property(e => e.PrCurcy)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.PrDateFrom).HasColumnType("datetime");

                entity.Property(e => e.PrDateTo).HasColumnType("datetime");

                entity.Property(e => e.PrPoid).HasColumnName("PrPOId");
            });

            modelBuilder.Entity<TMPorder>(entity =>
            {
                entity.HasKey(e => e.Poid)
                    .HasName("PK__T_M_POrd__5F02A2D416FBA9E5");

                entity.ToTable("T_M_POrder");

                entity.Property(e => e.Poid).HasColumnName("POId");

                entity.Property(e => e.PocumQty).HasColumnName("POCumQty");

                entity.Property(e => e.PodateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("PODateFrom");

                entity.Property(e => e.PodateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("PODateTo");

                entity.Property(e => e.PomatId).HasColumnName("POMatId");

                entity.Property(e => e.Poqty).HasColumnName("POQty");

                entity.Property(e => e.PostDate)
                    .HasColumnType("datetime")
                    .HasColumnName("POStDate");

                entity.Property(e => e.Postat)
                    .HasMaxLength(125)
                    .HasColumnName("POStat");

                entity.Property(e => e.PosupId).HasColumnName("POSupId");

                entity.Property(e => e.Potype)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("POType");
            });

            modelBuilder.Entity<TMRouting>(entity =>
            {
                entity.HasKey(e => e.RouId)
                    .HasName("PK__T_M_Rout__FF625823FFECC554");

                entity.ToTable("T_M_Routing");

                entity.Property(e => e.RouFase)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.RouOper)
                    .IsRequired()
                    .HasMaxLength(225);

                entity.Property(e => e.RouTunit)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("RouTUnit");

                entity.Property(e => e.RouWcid).HasColumnName("RouWCId");

                entity.Property(e => e.RouWtime).HasColumnName("RouWTime");

                entity.Property(e => e.RouWunit).HasColumnName("RouWUnit");
            });

            modelBuilder.Entity<TMStorage>(entity =>
            {
                entity.HasKey(e => e.MstorId)
                    .HasName("PK__T_M_Stor__C049AC3E8984595C");

                entity.ToTable("T_M_Storage");

                entity.Property(e => e.MstorId).HasColumnName("MStorId");

                entity.Property(e => e.MstorMatId).HasColumnName("MStorMatId");

                entity.Property(e => e.MstorStock).HasColumnName("MStorStock");
            });

            modelBuilder.Entity<TMaterial>(entity =>
            {
                entity.HasKey(e => e.MatId)
                    .HasName("PK__T_Materi__294E795529ACFE54");

                entity.ToTable("T_Material");

                entity.Property(e => e.MatClass).HasMaxLength(25);

                entity.Property(e => e.MatDescr).HasMaxLength(225);

                entity.Property(e => e.MatRefer).HasMaxLength(125);

                entity.Property(e => e.MatStDate).HasColumnType("datetime");

                entity.Property(e => e.MatStatus).HasMaxLength(125);

                entity.Property(e => e.MatType).HasMaxLength(25);

                entity.Property(e => e.MatUnMed).HasMaxLength(25);
            });
            modelBuilder.Entity<TPCareer>(entity =>
            {
                entity.HasKey(e => e.CareId)
                    .HasName("PK__T_P_Care__544993C70EBD1A4F");

                entity.ToTable("T_P_Career");

                entity.Property(e => e.CareDate).HasColumnType("datetime");

                entity.Property(e => e.CareObser).HasMaxLength(1250);

                entity.Property(e => e.CarePosit).HasMaxLength(10);
            });

            modelBuilder.Entity<TPContract>(entity =>
            {
                entity.HasKey(e => e.ConId)
                    .HasName("PK__T_P_Cont__E19F47C9E64D5872");

                entity.ToTable("T_P_Contract");

                entity.Property(e => e.ConObs).HasMaxLength(1250);

                entity.Property(e => e.ConRevDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TPCurric>(entity =>
            {
                entity.HasKey(e => e.CurrId)
                    .HasName("PK__T_P_Curr__AD7F3CC1B3ED079D");

                entity.ToTable("T_P_Curric");

                entity.Property(e => e.CurrArea).HasMaxLength(10);

                entity.Property(e => e.CurrAreaDesc).HasMaxLength(255);

                entity.Property(e => e.CurrObs).HasMaxLength(1250);

                entity.Property(e => e.CurrRevDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TPPay>(entity =>
            {
                entity.HasKey(e => e.PayId)
                    .HasName("PK__T_P_Pay__EE8FCECFD8268144");

                entity.ToTable("T_P_Pay");

                entity.Property(e => e.PayAccount).HasMaxLength(25);

                entity.Property(e => e.PayRet).HasMaxLength(10);

                entity.Property(e => e.PayStDate).HasColumnType("datetime");

                entity.Property(e => e.PayType).HasMaxLength(10);
            });

            modelBuilder.Entity<TPPresen>(entity =>
            {
                entity.HasKey(e => e.PresId)
                    .HasName("PK__T_P_Pres__1401ACF305270F5A");

                entity.ToTable("T_P_Presen");

                entity.Property(e => e.PresDateEvent).HasColumnType("datetime");

                entity.Property(e => e.PresLocal).HasMaxLength(10);

                entity.Property(e => e.PresTimeEvent).HasColumnType("datetime");
            });

            modelBuilder.Entity<TPReview>(entity =>
            {
                entity.HasKey(e => e.RevId)
                    .HasName("PK__T_P_Revi__D1EF131253800D46");

                entity.ToTable("T_P_Review");

                entity.Property(e => e.RevDate).HasColumnType("datetime");

                entity.Property(e => e.RevObj).HasMaxLength(1250);
            });

            modelBuilder.Entity<TPTrain>(entity =>
            {
                entity.HasKey(e => e.TrainId)
                    .HasName("PK__T_P_Trai__8ED2723AC8682FD2");

                entity.ToTable("T_P_Train");

                entity.Property(e => e.TrainArea).HasMaxLength(10);

                entity.Property(e => e.TrainCourse).HasMaxLength(10);

                entity.Property(e => e.TrainDate).HasColumnType("datetime");

                entity.Property(e => e.TrainObser).HasMaxLength(1250);
            });

            modelBuilder.Entity<TPerson>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("PK__T_Person__496D3DD0FE8E8B1D");

                entity.ToTable("T_Person");

                entity.Property(e => e.PerAddCtry).HasMaxLength(4);

                entity.Property(e => e.PerAddr).HasMaxLength(255);

                entity.Property(e => e.PerAddr1).HasMaxLength(255);

                entity.Property(e => e.PerBiCity).HasMaxLength(100);

                entity.Property(e => e.PerBiCtry).HasMaxLength(4);

                entity.Property(e => e.PerBird).HasColumnType("datetime");

                entity.Property(e => e.PerContDate).HasColumnType("datetime");

                entity.Property(e => e.PerDni)
                    .HasMaxLength(10)
                    .HasColumnName("PerDNI");

                entity.Property(e => e.PerEntDate).HasColumnType("datetime");

                entity.Property(e => e.PerExiDate).HasColumnType("datetime");

                entity.Property(e => e.PerName).HasMaxLength(100);

                entity.Property(e => e.PerName1).HasMaxLength(100);
            });

            modelBuilder.Entity<TSPlanning>(entity =>
            {
                entity.HasKey(e => e.PlanId)
                    .HasName("PK__T_S_Plan__755C22B7B93CE268");

                entity.ToTable("T_S_Planning");

                entity.Property(e => e.PlanDateFrom).HasColumnType("datetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("datetime");

                entity.Property(e => e.PlanFirmSt).HasMaxLength(55);
            });

            modelBuilder.Entity<TSProduct>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__T_S_Prod__042785E5A801BFEC");

                entity.ToTable("T_S_Product");

                entity.Property(e => e.ProdCrDate).HasColumnType("datetime");

                entity.Property(e => e.ProdDescr).HasMaxLength(225);

                entity.Property(e => e.ProdRefer).HasMaxLength(125);

                entity.Property(e => e.ProdStDate).HasColumnType("datetime");

                entity.Property(e => e.ProdStatus).HasMaxLength(125);
            });

            modelBuilder.Entity<TStorage>(entity =>
            {
                entity.HasKey(e => e.StorId)
                    .HasName("PK__T_Storag__961BFCE68517F23F");

                entity.ToTable("T_Storage");

                entity.Property(e => e.StorCode).HasMaxLength(125);

                entity.Property(e => e.StorDescr).HasMaxLength(225);

                entity.Property(e => e.StorStDate).HasColumnType("datetime");

                entity.Property(e => e.StorStatus).HasMaxLength(125);
            });
            modelBuilder.Entity<TSuplier>(entity =>
            {
                entity.HasKey(e => e.SupId)
                    .HasName("PK__T_Suplie__4D238596F0889CA1");

                entity.ToTable("T_Suplier");

                entity.Property(e => e.SupAcct).HasMaxLength(225);

                entity.Property(e => e.SupAdAdit).HasMaxLength(225);

                entity.Property(e => e.SupAdCity).HasMaxLength(225);

                entity.Property(e => e.SupAdCtry).HasMaxLength(4);

                entity.Property(e => e.SupAdStrt).HasMaxLength(225);

                entity.Property(e => e.SupCode).HasMaxLength(225);

                entity.Property(e => e.SupCrDate).HasColumnType("datetime");

                entity.Property(e => e.SupCtBankAcc).HasMaxLength(225);

                entity.Property(e => e.SupCtEdifin)
                    .HasMaxLength(100)
                    .HasColumnName("SupCtEDIFin");

                entity.Property(e => e.SupCtEdilog)
                    .HasMaxLength(100)
                    .HasColumnName("SupCtEDILog");

                entity.Property(e => e.SupCtEmailFin).HasMaxLength(125);

                entity.Property(e => e.SupCtEmailLog).HasMaxLength(125);

                entity.Property(e => e.SupCtPhone).HasMaxLength(55);

                entity.Property(e => e.SupCtWeb).HasMaxLength(225);

                entity.Property(e => e.SupNif)
                    .HasMaxLength(10)
                    .HasColumnName("SupNIF");

                entity.Property(e => e.SupRasoc).HasMaxLength(125);

                entity.Property(e => e.SupStDate).HasColumnType("datetime");

                entity.Property(e => e.SupStatus).HasMaxLength(25);
            });

            modelBuilder.Entity<TWccomponent>(entity =>
            {
                entity.HasKey(e => e.WcoId)
                    .HasName("PK__T_WCComp__BA5F4C267392F79C");

                entity.ToTable("T_WCComponent");

                entity.Property(e => e.WcoId).HasColumnName("WCoId");

                entity.Property(e => e.WcoAcct)
                    .HasMaxLength(255)
                    .HasColumnName("WCoAcct");

                entity.Property(e => e.WcoType)
                    .HasMaxLength(25)
                    .HasColumnName("WCoType");

                entity.Property(e => e.WcoCode)
                    .HasMaxLength(125)
                    .HasColumnName("WcoCode");

                entity.Property(e => e.WcoConsumW).HasColumnName("WCoConsumW");

                entity.Property(e => e.WcoCostMin).HasColumnName("WCoCostMin");

                entity.Property(e => e.WcoCrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WCoCrDate");

                entity.Property(e => e.WcoDescr)
                    .HasMaxLength(225)
                    .HasColumnName("WCoDescr");

                entity.Property(e => e.WcoDim1).HasColumnName("WCoDim1");

                entity.Property(e => e.WcoDim2).HasColumnName("WCoDim2");

                entity.Property(e => e.WcoDim3).HasColumnName("WCoDim3");

                entity.Property(e => e.WcoStDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WCoStDate");

                entity.Property(e => e.WcoStatus)
                    .HasMaxLength(125)
                    .HasColumnName("WCoStatus");

                entity.Property(e => e.WcoWcid).HasColumnName("WCoWCId");

                entity.Property(e => e.WcoWeight).HasColumnName("WCoWeight");
            });

            modelBuilder.Entity<TWorkCenter>(entity =>
            {
                entity.HasKey(e => e.WcdId)
                    .HasName("PK__T_WorkCe__B81F3E2A588EAA11");

                entity.ToTable("T_WorkCenter");

                entity.Property(e => e.WcdId).HasColumnName("WCdId");

                entity.Property(e => e.Wcacct)
                    .HasMaxLength(225)
                    .HasColumnName("WCAcct");

                entity.Property(e => e.Wccode)
                    .HasMaxLength(125)
                    .HasColumnName("WCCode");

                entity.Property(e => e.WccostMin).HasColumnName("WCCostMin");

                entity.Property(e => e.WccrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WCCrDate");

                entity.Property(e => e.Wcdescr)
                    .HasMaxLength(225)
                    .HasColumnName("WCDescr");

                entity.Property(e => e.WcfaId).HasColumnName("WCFaId");

                entity.Property(e => e.WcstDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WCStDate");

                entity.Property(e => e.Wcstatus)
                    .HasMaxLength(125)
                    .HasColumnName("WCStatus");

                entity.Property(e => e.Wcsupm2).HasColumnName("WCSupm2");

                entity.Property(e => e.Wctype)
                    .HasMaxLength(25)
                    .HasColumnName("WCType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
