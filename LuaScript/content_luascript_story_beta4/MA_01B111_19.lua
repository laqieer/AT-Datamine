-- このluaスクリプトは、MA_01B111_19.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_008)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101056","002","101056002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101029","002","101029002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101053","002","101053002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101054","002","101054002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101055","002","101055002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101029","002","101029002")
	template1()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()


	--★★ペレス★★:我らは捨て石<br>清らかなる水勢を抑えるべく
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190002")


	--★★ペレス★★:生き急がせぬべく
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190003")


	--★★アステラ★★:贖うつもりか、抗うつもりか
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","MA_01B111_190005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:ならば良い<br>それも良い
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190007")


	--★★ペレス★★:最強騎士は宿命を背負い<br>継承者は運命をまっとうせんと道を往く
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190008")


	--★★ペレス★★:騎士王が天命を<br>学び舎に捧げんとするならば──
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190009")


	--★★ペレス★★:聖杯城の王たるぺレス<br>妖精ニニアンの咎を雪ぐ死命
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190011")

-- ▼直接出力
PlayActionDirect(Actor002,"to Bow")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Bow")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Bow")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Bow")
-- ▲直接出力

	--★★アステラ_台詞★★:我ら<ruby=シルバタブラナイツ>銀卓騎士団</ruby><br><ruby=けが>穢</ruby>れなき魂を永遠の孤独から救う矜持
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01B111_190013")

	change_face(Actor001,"Anger")

	--★★ペレス★★:聖杯を砕き、騎士王を滅せ
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★アステラ★★:世界の救済<br>叶えさせはしないわ
	Talk(Actor002,"CHRNAME_ASTERA","speech","L","MA_01B111_190016")


	--★★ペレス★★:たとえ不具となろうと
	Talk(Actor001,"CHRNAME_PEREZ","speech","L","MA_01B111_190017")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101056","002","101056002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101029","002","101029002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101053","002","101053002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101054","002","101054002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101055","002","101055002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101029","002","101029002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
