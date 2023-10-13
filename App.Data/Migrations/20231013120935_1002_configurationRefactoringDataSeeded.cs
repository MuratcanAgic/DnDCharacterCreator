using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _1002_configurationRefactoringDataSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilites_Characters_CharacterId",
                table: "Abilites");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Characters_CharacterId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_CharacterId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Abilites_CharacterId",
                table: "Abilites");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ClassLevel",
                table: "Classess");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Abilites");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterLevel",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Wisdom",
                table: "Abilites",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Strength",
                table: "Abilites",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Intelligence",
                table: "Abilites",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Dexterity",
                table: "Abilites",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Constitution",
                table: "Abilites",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Charisma",
                table: "Abilites",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Classess",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9102), null, "Barbarian", null },
                    { 2, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9108), null, "Bard", null },
                    { 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9109), null, "Cleric", null },
                    { 4, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9110), null, "Druid", null },
                    { 5, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9111), null, "Fighter", null },
                    { 6, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9113), null, "Monk", null },
                    { 7, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9113), null, "Paladin", null },
                    { 8, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9114), null, "Ranger", null },
                    { 9, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9115), null, "Rogue", null },
                    { 10, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9116), null, "Sorcerer", null },
                    { 11, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9117), null, "Warlock", null },
                    { 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(9118), null, "Wizard", null }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(447), null, "Human", null },
                    { 2, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(452), null, "Elf", null },
                    { 3, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(453), null, "Drow", null },
                    { 4, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(454), null, "Half-Elf", null },
                    { 5, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(455), null, "Half-Orc", null },
                    { 6, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(456), null, "Halfling", null },
                    { 7, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(457), null, "Dwarf", null },
                    { 8, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(458), null, "Gnome", null },
                    { 9, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(458), null, "Tiefling", null },
                    { 10, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(460), null, "Githyanki", null },
                    { 11, new DateTime(2023, 10, 13, 15, 9, 35, 701, DateTimeKind.Local).AddTicks(461), null, "Dragonborn", null }
                });

            migrationBuilder.InsertData(
                table: "Subclasses",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(343), null, "Berserker", null },
                    { 2, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(348), null, "Wild Magic", null },
                    { 3, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(349), null, "Wildheart", null },
                    { 4, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(350), null, "College of Lore", null },
                    { 5, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(351), null, "College of Swords", null },
                    { 6, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(353), null, "College of Valour", null },
                    { 7, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(354), null, "Knowledge Domain", null },
                    { 8, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(355), null, "Life Domain", null },
                    { 9, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(355), null, "Light Domain", null },
                    { 10, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(356), null, "Nature Domain", null },
                    { 11, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(357), null, "Tempest Domain", null },
                    { 12, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(358), null, "Trickery Domain", null },
                    { 13, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(359), null, "Trickery War Domain", null },
                    { 14, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(389), null, "Circle of the Land", null },
                    { 15, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(390), null, "Circle of the Moon", null },
                    { 16, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(390), null, "Circle of the Spores", null },
                    { 17, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(391), null, "Battle Master", null },
                    { 18, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(393), null, "Champion", null },
                    { 19, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(393), null, "Eldritch Knight", null },
                    { 20, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(394), null, "Way of the Open Hand", null },
                    { 21, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(395), null, "Way of Shadow", null },
                    { 22, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(395), null, "Way of the Four Elements", null },
                    { 23, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(396), null, "Oath of the Ancients", null },
                    { 24, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(397), null, "Oath of Devotion", null },
                    { 25, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(397), null, "Oath of Vengeance", null },
                    { 26, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(398), null, "Oathbreaker", null },
                    { 27, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(399), null, "Hunter", null },
                    { 28, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(399), null, "Beast Master", null },
                    { 29, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(400), null, "Gloom Stalker", null },
                    { 30, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(401), null, "Arcane Trickster", null },
                    { 31, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(401), null, "Thief", null },
                    { 32, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(402), null, "Assassin", null },
                    { 33, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(403), null, "Draconic Bloodline", null },
                    { 34, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(404), null, "Wild Magic", null },
                    { 35, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(405), null, "Storm Sorcery", null },
                    { 36, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(406), null, "The Archfey", null },
                    { 37, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(406), null, "The Fiend", null },
                    { 38, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(407), null, "The Great Old One", null },
                    { 39, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(407), null, "Abjuration School", null },
                    { 40, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(408), null, "Conjuration School", null },
                    { 41, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(409), null, "Divination School", null },
                    { 42, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(409), null, "Enchantment School", null },
                    { 43, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(410), null, "Evocation School", null },
                    { 44, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(411), null, "Illusion School", null },
                    { 45, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(411), null, "Necromancy School", null },
                    { 46, new DateTime(2023, 10, 13, 15, 9, 35, 702, DateTimeKind.Local).AddTicks(412), null, "Transmutation School", null }
                });

            migrationBuilder.InsertData(
                table: "ClassSubclasses",
                columns: new[] { "Id", "ClassId", "CreatedDate", "DeletedDate", "SubclassId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7651), null, 1, null },
                    { 2, 1, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7664), null, 2, null },
                    { 3, 1, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7665), null, 3, null },
                    { 4, 2, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7666), null, 4, null },
                    { 5, 2, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7667), null, 5, null },
                    { 6, 2, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7669), null, 6, null },
                    { 7, 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7670), null, 7, null },
                    { 8, 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7670), null, 8, null },
                    { 9, 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7671), null, 9, null },
                    { 10, 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7673), null, 10, null },
                    { 11, 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7673), null, 11, null },
                    { 12, 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7674), null, 12, null },
                    { 13, 3, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7675), null, 13, null },
                    { 14, 4, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7676), null, 14, null },
                    { 15, 4, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7676), null, 15, null },
                    { 16, 4, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7677), null, 16, null },
                    { 17, 5, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7678), null, 17, null },
                    { 18, 5, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7679), null, 18, null },
                    { 19, 5, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7680), null, 19, null },
                    { 20, 6, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7681), null, 20, null },
                    { 21, 6, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7682), null, 21, null },
                    { 22, 6, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7682), null, 22, null },
                    { 23, 7, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7683), null, 23, null },
                    { 24, 7, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7684), null, 24, null },
                    { 25, 7, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7685), null, 25, null },
                    { 26, 7, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7685), null, 26, null },
                    { 27, 8, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7686), null, 27, null },
                    { 28, 8, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7687), null, 28, null },
                    { 29, 8, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7687), null, 29, null },
                    { 30, 9, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7688), null, 30, null },
                    { 31, 9, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7689), null, 31, null },
                    { 32, 9, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7690), null, 32, null },
                    { 33, 10, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7691), null, 33, null },
                    { 34, 10, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7692), null, 34, null },
                    { 35, 10, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7693), null, 35, null },
                    { 36, 11, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7693), null, 36, null },
                    { 37, 11, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7694), null, 37, null },
                    { 38, 11, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7695), null, 38, null },
                    { 39, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7696), null, 39, null },
                    { 40, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7696), null, 40, null },
                    { 41, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7697), null, 41, null },
                    { 42, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7698), null, 42, null },
                    { 43, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7698), null, 43, null },
                    { 44, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7699), null, 44, null },
                    { 45, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7700), null, 45, null },
                    { 46, 12, new DateTime(2023, 10, 13, 15, 9, 35, 700, DateTimeKind.Local).AddTicks(7701), null, 46, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AbilityId",
                table: "Characters",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Abilites_AbilityId",
                table: "Characters",
                column: "AbilityId",
                principalTable: "Abilites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Abilites_AbilityId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AbilityId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_RaceId",
                table: "Characters");

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ClassSubclasses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classess",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Subclasses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassLevel",
                table: "Classess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterLevel",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Wisdom",
                table: "Abilites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Strength",
                table: "Abilites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Intelligence",
                table: "Abilites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Dexterity",
                table: "Abilites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Constitution",
                table: "Abilites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Charisma",
                table: "Abilites",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Abilites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Races_CharacterId",
                table: "Races",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Abilites_CharacterId",
                table: "Abilites",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abilites_Characters_CharacterId",
                table: "Abilites",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Characters_CharacterId",
                table: "Races",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
