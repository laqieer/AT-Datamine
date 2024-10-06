-- このluaスクリプトは、MA_01104_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",340,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera002 = SetTemplate("Actor002",-44,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera003 = SetTemplate("Actor003",180,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera004 = SetTemplate("Actor004",134,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
off_active(Actor004) -- ディナタン非表示
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()


	--★★アーサー★★:学内は喧々諤々だなあ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01104_200002")


	--★★知将ケイ★★:武器を持たぬ騎士などいるか<br>それも敵に雇われていた傭兵風情に席など
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_200003")

	PlayAction(Actor002,"to  Std_No")

	--★★知将ケイ★★:…ノワールが『妖精殺し』の息子だと<br>知れ渡れば収拾がつかなくなる
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_200004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:落とし前はつけさせるさ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_200005")


	--★★知将ケイ★★:その咎を、誰が？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_200006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ランスロット★★:そのために俺がいる
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_200008")

	change_face(Actor002,"Anger")

	--★★知将ケイ★★:…ランスロット<br>貴公はなにを知っている？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_200009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:なさねばならないことを
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_200011")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
se_play("SE_ADV_MA_01104_20_DoorOpen")
wait_time(TIME_ELAPSED + FADE_TIME)
on_active(Actor004) -- ディナタン表示
DontChangeRandomCamera(true)
on_camera(RndCamera008)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.6)
DontChangeRandomCamera(false)
turn_chara(Actor002, -65,0)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ディナタン★★:………ランス、ロット卿
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01104_200013")


	--★★知将ケイ★★:…昔馴染みとは言え無礼極まりないな<br>父も父なら兄も兄、妹も－－
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_200015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★ディナタン★★:礼を失したことは謝ります…<br>でも、兄を侮蔑するのはやめてください
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01104_200016")

	change_face(Actor002,"Normal")

	--★★知将ケイ★★:礼を失したことを謝ろう
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_200017")


	--★★アーサー★★:まあまあまあ<br>積もる話があるだろう
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01104_200018")


	--★★ランスロット★★:…ディナタン<br>そう心配しなくていい
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_200019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")

	--★★ディナタン★★:なにか理由があるんだよね…？<br>兄さんを行かせたのにも
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01104_200020")


	--★★ディナタン★★:なにも言ってくれないのにも…ワケが
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01104_200021")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力

	--★★アーサー★★:…彼ならカリバーンを抜けると<br>なぜ思う？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01104_200022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ランスロット★★:そうならなければならないんだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_200023")


	--★★ディナタン★★:ランス兄ちゃん…？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01104_200024")

	change_face(Actor003,"Smile")

	--★★ランスロット★★:武器を預かり<br>必ず帰って来るさ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01104_200025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
