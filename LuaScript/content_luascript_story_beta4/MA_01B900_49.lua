-- このluaスクリプトは、MA_01B900_49.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("101020300", "content_still_10102030_image", "101020300_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101020310", "content_still_10102031_image", "101020310_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101020300",0,0,0,true,false)
-- ▲直接出力
-- ▼直接出力
set_position_image(930,-540)
set_scale_image(2.5,2.5)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110072)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.5)
--[[
fadeout(0,0,0,0,0.25)
wait_time(0.25)
scale_to_image(1,1,0,2)
move_to_image(0,0,0,2)
wait_time(0.2)
fadein(0.25)
wait_time(1.0)
]]
scale_to_image(1,1,1.7,"EaseOut")
move_to_image(0,0,1.7,"EaseOut")
wait_time(2.4)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:どうして、その残滓が<br>白き竜を形どっているの…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_490002")


	--★★ギネヴィア★★:わたしたちブリテンに住む者の<br>『侵略者』に対する潜在的意識の具現化らしいわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B900_490003")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:止められるのは、兄さんだけ…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_490004")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
wait_time(2.0)
PlayActionDirect(Actor003,"to Std_Loop")
fadeout(0,0,0,0,0.25)
wait_time(0.25)
show_image("101020310",0,0,0,true,false)
wait_time(0.2)
fadein(0.25)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:世界平和の代わりに<br>継承者が一生の傷を背負うってどーよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_490006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…自己犠牲でしかないよね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B900_490007")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:それで平和に暮らせんのかよ<br>オニーサン自身はさ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_490008")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:考えたことあるわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B900_490009")


	--★★ギネヴィア★★:戦いが終わって、武器を失った騎士に<br>どんな価値が残るのか
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B900_490010")


	--★★ディナタン★★:けど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_490011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:ああ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_490012")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:それでも兄さんは私の兄さんだから<br>戦いがないころから、今までずっと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_490013")


	--★★ギネヴィア★★:…そうね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B900_490014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:わたしにとっても、頼もしい友達
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B900_490015")


	--★★ギネヴィア★★:帰って来るよね、学園に
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01B900_490016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101020300", "content_still_10102030_image", "101020300_StillImage")
load_image_preload("101020310", "content_still_10102031_image", "101020310_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110072)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
