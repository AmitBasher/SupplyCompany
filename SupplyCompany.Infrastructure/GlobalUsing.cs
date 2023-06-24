global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;

global using Microsoft.Extensions.Options;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.IdentityModel.Protocols;

global using SupplyCompany.Application.Interfaces.Repositories;
global using SupplyCompany.Application.Common.Interfaces.Services;
global using SupplyCompany.Application.Common.Interfaces.Authentication;

global using SupplyCompany.Infrastructure.Services;
global using SupplyCompany.Infrastructure.Authentication;
global using SupplyCompany.Infrastructure.DAL;
global using SupplyCompany.Infrastructure.DAL.Repository;
//Domain Models
global using SupplyCompany.Domain.Models.Common;
global using SupplyCompany.Domain.Models.user;
global using SupplyCompany.Domain.Models.supplier;
global using SupplyCompany.Domain.Models.customer;
global using SupplyCompany.Domain.Models.product;

global using SupplyCompany.Domain.Models.product.Entity.subProduct;
global using SupplyCompany.Domain.Models.product.Entity.subProduct.ValueObjects;
global using SupplyCompany.Domain.Models.supplyRequest;
global using SupplyCompany.Domain.Models.supplierReview;
global using SupplyCompany.Domain.Models.productReview;
global using SupplyCompany.Domain.Models.order;

