using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Http;

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

        public virtual DbSet<TInputBLH> TInputBLHs { get; set; }
        public virtual DbSet<TInputBLD> TInputBLDs { get; set; }
        public virtual DbSet<TCCplanning> TCCplannings { get; set; }
        public virtual DbSet<TCCplant> TCCplants { get; set; }
        public virtual DbSet<TCCplantPort> TCCplantPorts { get; set; }
        public virtual DbSet<TCCproduct> TCCproducts { get; set; }
        public virtual DbSet<TChart> TCharts { get; set; }
        public virtual DbSet<TChartRol> TChartRols { get; set; }
        public virtual DbSet<TCPorder> TCPorders { get; set; }
        public virtual DbSet<TCScShop> TCScShops { get; set; }
        public virtual DbSet<TCTimeRule> TCTimeRules { get; set; }
        public virtual DbSet<TCSched> TCScheds { get; set; }
        public virtual DbSet<TCTrSched> TCTrScheds { get; set; }
        public virtual DbSet<TCTruck> TCTrucks { get; set; }

        public virtual DbSet<TCustomer> TCustomers { get; set; }
        public virtual DbSet<TExpMater> TExpMaters { get; set; }
        public virtual DbSet<TExpOper> TExpOpers { get; set; }
        public virtual DbSet<TExpOperd> TExpOperds { get; set; }
        public virtual DbSet<TExpMatd> TExpMatds { get; set; }
        public virtual DbSet<TExplosion> TExplosions { get; set; }
        public virtual DbSet<TExplosionB> TExplosionBs { get; set; }
        public virtual DbSet<TFacility> TFacilities { get; set; }
        public virtual DbSet<TLocation> TLocations { get; set; }
        public virtual DbSet<TMComponent> TMComponents  { get; set; }
        public virtual DbSet<TMLocation> TMLocations { get; set; }
        public virtual DbSet<TMPoprice> TMPoprices { get; set; }
        public virtual DbSet<TMPorder> TMPorders { get; set; }
        public virtual DbSet<TMRouting> TMRoutings { get; set; }
        public virtual DbSet<TMStorage> TMStorages { get; set; }
        public virtual DbSet<TMaterial> TMaterials { get; set; }
        public virtual DbSet<TOperator> TOperators { get; set; }
        public virtual DbSet<TOrganizacion> TOrganizacions { get; set; }
        public virtual DbSet<TPCareer> TPCareers { get; set; }
        public virtual DbSet<TPContract> TPContracts { get; set; }
        public virtual DbSet<TPCurric> TPCurrics { get; set; }
        public virtual DbSet<TPPay> TPPays { get; set; }
        public virtual DbSet<TPPresen> TPPresens { get; set; }
        public virtual DbSet<TPReview> TPReviews { get; set; }
        public virtual DbSet<TPTrain> TPTrains { get; set; }
        public virtual DbSet<TPerson> TPersons { get; set; }
        public virtual DbSet<TNexPrev> TNexPrevs { get; set; }
        public virtual DbSet<TSPlanning> TSPlannings { get; set; }
        public virtual DbSet<TSPorder> TSPorders { get; set; }
        public virtual DbSet<TSProduct> TSProducts { get; set; }
        public virtual DbSet<TStorage> TStorages { get; set; }
        public virtual DbSet<TSuplier> TSupliers { get; set; }
        public virtual DbSet<TUsRol> TUsRols { get; set; }

        public virtual DbSet<TUser> TUsers { get; set; }
        public virtual DbSet<TWccomponent> TWccomponents { get; set; }
        public virtual DbSet<TWcoperator> TWcoperators { get; set; }
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

            modelBuilder.Entity<TInputBLH>(entity =>
            {
                entity.HasKey(e => e.InBLId)
                    .HasName("PK__T_InputBLH_InBLId");

                entity.ToTable("T_InputBLH");

                entity.Property(e => e.InBLId).HasColumnName("InBLId");

                entity.Property(e => e.InBLSupId).HasColumnName("InBLSupId");

                entity.Property(e => e.InBLDateRec)
                    .HasColumnType("datetime")
                    .HasColumnName("InBLDateRec");

                entity.Property(e => e.InBLStatus).HasColumnName("InBLStatus");

                entity.Property(e => e.InBLObser).HasColumnName("InBLObser");

                entity.Property(e => e.InBLDateStat)
                    .HasColumnType("datetime")
                    .HasColumnName("InBLDateStat");

            });

            modelBuilder.Entity<TInputBLD>(entity =>
            {
                entity.HasKey(e => e.InBLDId)
                    .HasName("PK__T_InputBLD_InBLDId");

                entity.ToTable("T_InputBLD");

                entity.Property(e => e.InBLDId).HasColumnName("InBLDId");

                entity.Property(e => e.InBLDProdId).HasColumnName("InBLDProdId");

                entity.Property(e => e.InBLDQty).HasColumnName("InBLDQty");

                entity.Property(e => e.InBLDUM).HasColumnName("InBLDUM");

                entity.Property(e => e.InBLDUMRef).HasColumnName("InBLDUMRef");

                entity.Property(e => e.InBLDStat).HasColumnName("InBLDStat");

            });

            modelBuilder.Entity<TCCplanning>(entity =>
            {
                entity.HasKey(e => e.CplanId)
                    .HasName("PK__T_C_CPla__0600298FED524920");

                entity.ToTable("T_C_CPlanning");

                entity.Property(e => e.CplanId).HasColumnName("CPlanId");

                entity.Property(e => e.CplanCmatId).HasColumnName("CplanCMatId");

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

                entity.Property(e => e.CplanTruckId).HasColumnName("CPlanTruckId");

                entity.Property(e => e.CplanUemb).HasColumnName("CPlanUEmb");
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

                entity.Property(e => e.CplantTruckId).HasColumnName("CPlantTruckId");
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

            modelBuilder.Entity<TCScShop>(entity =>
            {
                entity.HasKey(e => e.ShopId)
                    .HasName("PK__T_C_ScSh__67C557C90C0DCE2A");

                entity.ToTable("T_C_ScShop");

                entity.Property(e => e.ShopComent).HasMaxLength(225);

                entity.Property(e => e.ShopCprodId).HasColumnName("ShopCProdId");

                entity.Property(e => e.ShopDate).HasColumnType("datetime");

                entity.Property(e => e.ShopFg)
                    .HasMaxLength(50)
                    .HasColumnName("ShopFG");

                entity.Property(e => e.ShopFrom).HasColumnType("datetime");

                entity.Property(e => e.ShopTo).HasColumnType("datetime");

                entity.Property(e => e.ShopTunit).HasColumnName("ShopTUnit");

                entity.Property(e => e.ShopUemb).HasColumnName("ShopUEmb");

                entity.Property(e => e.ShopaTunit).HasColumnName("ShopaTUnit");

                entity.Property(e => e.Shopuser).HasColumnName("ShopUser");
            });

            modelBuilder.Entity<TCTimeRule>(entity =>
            {
                entity.HasKey(e => e.ShopId)
                    .HasName("PK__T_C_TimeR__67C557C90C0DCE2A");

                entity.ToTable("T_C_TimeRule");

                entity.Property(e => e.Wccode)
                    .HasMaxLength(125)
                    .HasColumnName("WCCode");

                entity.Property(e => e.Wcdescr)
                    .HasMaxLength(225)
                    .HasColumnName("WCDescr");

                entity.Property(e => e.MatDescr).HasMaxLength(225);

                entity.Property(e => e.MatRefer).HasMaxLength(125);

                entity.Property(e => e.ShopComent).HasMaxLength(225);

                entity.Property(e => e.ShopCprodId).HasColumnName("ShopCProdId");

                entity.Property(e => e.ShopDate).HasColumnType("datetime");

                entity.Property(e => e.ShopFg)
                    .HasMaxLength(50)
                    .HasColumnName("ShopFG");

                entity.Property(e => e.ShopFrom).HasColumnType("datetime");

                entity.Property(e => e.ShopTo).HasColumnType("datetime");

                entity.Property(e => e.ShopTunit).HasColumnName("ShopTUnit");

                entity.Property(e => e.ShopUemb).HasColumnName("ShopUEmb");

                entity.Property(e => e.ShopaTunit).HasColumnName("ShopaTUnit");

                entity.Property(e => e.Shopuser).HasColumnName("ShopUser");
            });


            modelBuilder.Entity<TCSched>(entity =>
            {
                entity.HasKey(e => e.ScId)
                    .HasName("PK__T_C_Sche__ACB791DAC60C33A1");

                entity.ToTable("T_C_Sched");

                entity.Property(e => e.ScComent).HasMaxLength(225);

                entity.Property(e => e.ScCprodId).HasColumnName("ScCProdId");

                entity.Property(e => e.ScDate).HasColumnType("datetime");

                entity.Property(e => e.ScFrom).HasColumnType("datetime");

                entity.Property(e => e.ScTo).HasColumnType("datetime");

                entity.Property(e => e.ScUemb).HasColumnName("ScUEmb");
            });

            modelBuilder.Entity<TCTrSched>(entity =>
            {
                entity.HasKey(e => e.TrScId)
                    .HasName("PK__T_C_TrSc__DECC2FE248DFF9ED");

                entity.ToTable("T_C_TrSched");

                entity.Property(e => e.TrScCode).HasMaxLength(225);

                entity.Property(e => e.TrScCrDeparture).HasColumnType("datetime");

                entity.Property(e => e.TrScCrLoadStart).HasColumnType("datetime");

                entity.Property(e => e.TrScDeno).HasMaxLength(225);
            });

            modelBuilder.Entity<TCTruck>(entity =>
            {
                entity.HasKey(e => e.TruckId)
                    .HasName("PK__T_C_Truc__6632E97B2BE769DA");

                entity.ToTable("T_C_Truck");

                entity.Property(e => e.TruckCode).HasMaxLength(225);

                entity.Property(e => e.TruckCrDate).HasColumnType("datetime");

                entity.Property(e => e.TruckDeno).HasMaxLength(225);
            });

            modelBuilder.Entity<TChart>(entity =>
            {
                entity.HasKey(e => e.CharId)
                    .HasName("PK__T_Chart__AA7BC274F083FB15");

                entity.ToTable("T_Chart");

                entity.Property(e => e.CharAdress).HasMaxLength(225);

                entity.Property(e => e.CharAdressad).HasMaxLength(225);

                entity.Property(e => e.CharCity).HasMaxLength(125);

                entity.Property(e => e.CharCode).HasMaxLength(125);

                entity.Property(e => e.CharCtry).HasMaxLength(125);

                entity.Property(e => e.CharDate).HasColumnType("datetime");

                entity.Property(e => e.CharEmail).HasMaxLength(125);

                entity.Property(e => e.CharName).HasMaxLength(225);

                entity.Property(e => e.CharTel).HasMaxLength(125);

                entity.Property(e => e.CharWeb).HasMaxLength(125);
            });

            modelBuilder.Entity<TChartRol>(entity =>
            {
                entity.HasKey(e => e.RcharId)
                    .HasName("PK__T_Chart___F67669D4612FE92F");

                entity.ToTable("T_Chart_Rol");

                entity.Property(e => e.RcharId).HasColumnName("RCharId");

                entity.Property(e => e.RcharCharId).HasColumnName("RCharCharId");

                entity.Property(e => e.RcharRolId).HasColumnName("RCharRolId");
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

            modelBuilder.Entity<TExpMater>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_ExpMater");

                entity.Property(e => e.ExpComp).HasMaxLength(125);

                entity.Property(e => e.MatDescr).HasMaxLength(225);

                entity.Property(e => e.MatRefer).HasMaxLength(125);

                entity.Property(e => e.MatUnMed).HasMaxLength(25);

                entity.Property(e => e.TComQty).HasColumnName("TComQty");

                entity.Property(e => e.TCom).HasColumnName("TCom");
            });

            modelBuilder.Entity<TExpOper>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_ExpOper");

                entity.Property(e => e.Wccode)
                    .HasMaxLength(125)
                    .HasColumnName("WCCode");

                entity.Property(e => e.Wcdescr)
                    .HasMaxLength(225)
                    .HasColumnName("WCDescr");
            });

            modelBuilder.Entity<TExpOperd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_ExpOperd");

                entity.Property(e => e.expcomp)
                    .HasMaxLength(125)
                    .HasColumnName("expcomp");

                entity.Property(e => e.Qty)
                    .HasMaxLength(125)
                    .HasColumnName("Qty");

                entity.Property(e => e.matunmed)
                    .HasMaxLength(25)
                    .HasColumnName("matunmed");

                entity.Property(e => e.TTime)
                    .HasMaxLength(125)
                    .HasColumnName("TTime");

                entity.Property(e => e.rouwcid)
                    .HasMaxLength(125)
                    .HasColumnName("rouwcid");

                entity.Property(e => e.matrefer)
                    .HasMaxLength(125)
                    .HasColumnName("matrefer");

                entity.Property(e => e.matdescr)
                    .HasMaxLength(225)
                    .HasColumnName("matdescr");

                entity.Property(e => e.roufase)
                    .HasMaxLength(25)
                    .HasColumnName("roufase");

                entity.Property(e => e.rouoper)
                    .HasMaxLength(225)
                    .HasColumnName("rouoper");

                entity.Property(e => e.TTimes)
                    .HasMaxLength(225)
                    .HasColumnName("TTimes");
            });

            modelBuilder.Entity<TExpMatd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_ExpMatd");

                entity.Property(e => e.expcomp)
                    .HasMaxLength(125)
                    .HasColumnName("expcomp");

                entity.Property(e => e.matrefer)
                    .HasMaxLength(125)
                    .HasColumnName("matrefer");

                entity.Property(e => e.matdescr)
                    .HasMaxLength(225)
                    .HasColumnName("matdescr");

                entity.Property(e => e.TComQty)
                    .HasMaxLength(125)
                    .HasColumnName("TComQty");

                entity.Property(e => e.matunmed)
                    .HasMaxLength(25)
                    .HasColumnName("matunmed");

                entity.Property(e => e.SPoId)
                    .HasMaxLength(125)
                    .HasColumnName("SPoId");

                entity.Property(e => e.SPoSupId)
                    .HasMaxLength(125)
                    .HasColumnName("SPoSupId");

                entity.Property(e => e.SPOReferEx)
                    .HasMaxLength(25)
                    .HasColumnName("SPOReferEx");

                entity.Property(e => e.SPOPO)
                    .HasMaxLength(225)
                    .HasColumnName("SPOPO");

                entity.Property(e => e.SPOPrice)
                    .HasMaxLength(225)
                    .HasColumnName("SPOPrice");

                entity.Property(e => e.SPoCurcy)
                    .HasMaxLength(225)
                    .HasColumnName("SPoCurcy");

                entity.Property(e => e.SPoPcRep)
                    .HasMaxLength(225)
                    .HasColumnName("SPoPcRep");

                entity.Property(e => e.SupId)
                    .HasMaxLength(225)
                    .HasColumnName("SupId");

                entity.Property(e => e.SupRaSoc)
                    .HasMaxLength(225)
                    .HasColumnName("SupRaSoc");

                entity.Property(e => e.SPoPcRequ)
                    .HasMaxLength(225)
                    .HasColumnName("SPoPcRequ");
            });


            modelBuilder.Entity<TExplosion>(entity =>
            {
                entity.HasKey(e => e.ExpId)
                    .HasName("PK__T_Explos__45B117E7E9263F57");

                entity.ToTable("T_Explosion");

                entity.Property(e => e.ExpRefer).HasMaxLength(125);

                entity.Property(e => e.ExpDescr).HasMaxLength(225);

                entity.Property(e => e.ExpsLevel).HasMaxLength(25);

                entity.Property(e => e.ExpUM).HasMaxLength(25);
            });
            modelBuilder.Entity<TExplosionB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_ExplosionB");

                entity.Property(e => e.ExpDescr).HasMaxLength(225);

                entity.Property(e => e.ExpRefer).HasMaxLength(125);

                entity.Property(e => e.ExpRouFase).HasMaxLength(25);

                entity.Property(e => e.ExpRouOper).HasMaxLength(225);

                entity.Property(e => e.ExpRouTunit)
                    .HasMaxLength(25)
                    .HasColumnName("ExpRouTUnit");

                entity.Property(e => e.ExpUm)
                    .HasMaxLength(25)
                    .HasColumnName("ExpUM");

                entity.Property(e => e.ExpsLevel).HasMaxLength(25);
                entity.Property(e => e.WCCode).HasMaxLength(125);
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

            modelBuilder.Entity<TLocation>(entity =>
            {
                entity.HasKey(e => e.LocId)
                    .HasName("PK__T_Locati__6A46DE8955CD23A6");

                entity.ToTable("T_Locations");

                entity.Property(e => e.LocAcct).HasMaxLength(225);

                entity.Property(e => e.LocCode).HasMaxLength(125);

                entity.Property(e => e.LocCrDate).HasColumnType("datetime");

                entity.Property(e => e.LocDescr).HasMaxLength(225);

                entity.Property(e => e.LocStDate).HasColumnType("datetime");

                entity.Property(e => e.LocStatus).HasMaxLength(125);

                entity.Property(e => e.LocType).HasMaxLength(25);
            });

            modelBuilder.Entity<TMComponent>(entity =>
            {
                entity.HasKey(e => e.CoId)
                    .HasName("PK__T_M_Comp__A25F3E2B8E4CCFA4");

                entity.ToTable("T_M_Component");

                entity.Property(e => e.CoStDate).HasColumnType("datetime");

                entity.Property(e => e.CoStat).HasMaxLength(125);
            });

            modelBuilder.Entity<TMLocation>(entity =>
            {
                entity.HasKey(e => e.MLocId)
                    .HasName("PK__T_M_Loca__EC8E957571BCE195");

                entity.ToTable("T_M_Locations");

                entity.Property(e => e.MLocId).HasColumnName("mLocId");

                entity.Property(e => e.MLocLodId).HasColumnName("mLocLodId");

                entity.Property(e => e.MLocMatId).HasColumnName("mLocMatId");

                entity.Property(e => e.MLocStock).HasColumnName("mLocStock");

                entity.Property(e => e.RLocStock).HasColumnName("rLocStock");

                entity.Property(e => e.XLocStock).HasColumnName("xLocStock");
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

            modelBuilder.Entity<TOperator>(entity =>
            {
                entity.HasKey(e => e.OpeId)
                    .HasName("PK__T_Operat__7F2A4FC62AA056F6");

                entity.ToTable("T_Operator");

                entity.Property(e => e.OpeAcct).HasMaxLength(125);

                entity.Property(e => e.OpeCode).HasMaxLength(25);

                entity.Property(e => e.OpeCurcy).HasMaxLength(25);

                entity.Property(e => e.OpeDesc).HasMaxLength(225);
            });

            modelBuilder.Entity<TOrganizacion>(entity =>
            {
                entity.HasKey(e => e.OrgId)
                    .HasName("PK__T_Organi__420C9E6CE3A74B13");

                entity.ToTable("T_Organizacion");

                entity.Property(e => e.OrgAdress).HasMaxLength(225);

                entity.Property(e => e.OrgAdressad).HasMaxLength(225);

                entity.Property(e => e.OrgCity).HasMaxLength(125);

                entity.Property(e => e.OrgCode).HasMaxLength(125);

                entity.Property(e => e.OrgCtry).HasMaxLength(125);

                entity.Property(e => e.OrgDate).HasColumnType("datetime");

                entity.Property(e => e.OrgEmail).HasMaxLength(125);

                entity.Property(e => e.OrgName).HasMaxLength(225);

                entity.Property(e => e.OrgNif)
                    .HasMaxLength(125)
                    .HasColumnName("OrgNIF");

                entity.Property(e => e.OrgTel).HasMaxLength(125);

                entity.Property(e => e.OrgWeb).HasMaxLength(125);
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

            modelBuilder.Entity<TNexPrev>(entity =>
            {
                entity.HasKey(e => e._Id)
                    .HasName("PK__T_NexPrev__496D3DD0FE8E8B1D");

                entity.ToTable("T_NexPrev");

                entity.Property(e => e._Idnext).HasMaxLength(4);

                entity.Property(e => e._idprev).HasMaxLength(255);

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

            modelBuilder.Entity<TSPorder>(entity =>
            {
                entity.HasKey(e => e.Spoid)
                    .HasName("PK__T_S_POrd__BD87825083A3CB29");

                entity.ToTable("T_S_POrder");

                entity.Property(e => e.Spoid).HasColumnName("SPOId");

                entity.Property(e => e.SpocprodId).HasColumnName("SPOCProdId");

                entity.Property(e => e.Spocurcy)
                    .HasMaxLength(25)
                    .HasColumnName("SPOCurcy");

                entity.Property(e => e.Spodate)
                    .HasColumnType("datetime")
                    .HasColumnName("SPODate");

                entity.Property(e => e.Spopo)
                    .HasMaxLength(125)
                    .HasColumnName("SPOPO");

                entity.Property(e => e.Spoprice).HasColumnName("SPOPrice");

                entity.Property(e => e.SporeferEx)
                    .HasColumnName("SPOReferEx");

                entity.Property(e => e.Spostatus)
                    .HasColumnName("SPOStatus");

                entity.Property(e => e.SpoDateSt)
                    .HasColumnType("datetime")
                    .HasColumnName("SpoDateSt");

                entity.Property(e => e.SpoPcRep)
                    .HasColumnName("SpoPcRep");

                entity.Property(e => e.SposupId).HasColumnName("SPOSupId");

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

            modelBuilder.Entity<TUsRol>(entity =>
            {
                entity.HasKey(e => e.UsRolId)
                    .HasName("PK__T_UsRol__4657E5364746CC13");

                entity.ToTable("T_UsRol");

                entity.Property(e => e.UsRolId).HasColumnName("UsRolID");

                entity.Property(e => e.UsRolDateEnd).HasColumnType("datetime");

                entity.Property(e => e.UsRolName)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__T_Users__1788CCAC456FBD1C");

                entity.ToTable("T_Users");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserFirstName).HasMaxLength(40);

                entity.Property(e => e.UserLastName).HasMaxLength(40);

                entity.Property(e => e.UserLoginName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UserPassDate).HasColumnType("datetime");

                entity.Property(e => e.UserPasswordHash)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsFixedLength(true);

                entity.Property(e => e.UserStatus)
                    .IsRequired()
                    .HasMaxLength(4);
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

            modelBuilder.Entity<TWcoperator>(entity =>
            {
                entity.HasKey(e => e.WcopId)
                    .HasName("PK__T_WCOper__A18DE990AC098384");

                entity.ToTable("T_WCOperator");

                entity.Property(e => e.WcopId).HasColumnName("WCOpId");

                entity.Property(e => e.WcopNum).HasColumnName("WCOpNum");

                entity.Property(e => e.WcopOpId).HasColumnName("WCOpOpId");

                entity.Property(e => e.WcopWcid).HasColumnName("WCOpWCId");
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
