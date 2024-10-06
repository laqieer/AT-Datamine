-- このluaスクリプトは、MA_01104_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-58.7,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",84.8,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera004 = SetTemplate("Actor004",211.4,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Hide(Actor001)
Hide(Actor003)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
load_image("102010010_StillImage", "content_still_10201001_image", "102010010_StillImage")

load_image("still001", "content_still_10301032_image", "103010320_StillImage")
-- ▲直接出力
-- ▼直接出力
 load_image("101010140_1", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
FX_Camera1    = load_particle("content_effect3d_common_adv", "Ef_C_Adv_SwordWind", false, false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_DarkBrave")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.9)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
change_face(Actor002,"Surprise")
wait_time(1.1)
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor001,Camera001,EntryData110071_01_05,CameraAssetBundleName110071_01,CameraPos110071_01_105)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,108.8,0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-224.8,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Surprise")

	--★★ウレリー★★:裏口入学だったんだ？
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:推薦入学のはずだったんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1040003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Serious")

	--★★ウレリー★★:ケイ卿の気持ちはわからないわけでもないよ<br>彼はカレドニアの脅威に神経をすり減らしてる
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040004")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:カレドニア王ライエンスの兵力は圧倒的だよ
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040006")


	--★★ノワール★★:ライエンス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1040007")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ウレリー★★:会ったことは？
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:まさか。顔すら知らないよ<br><ruby=おれたち>傭兵団</ruby>の雇い主はカレドニアの末端だったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1040009")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:でも、何も知らされていなかったんです<br>あんな<ruby=バルバロイ>化け物</ruby>が…カレドニアにいたことなんか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1040011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ウレリー★★:『バルバロイ』という存在自体は？
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040013")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ログレスに侵攻を続ける東の大国カレドニア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1040014")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ウレリー★★:…教えてあげる
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040016")

-- ▼直接出力
bgm_play("BGM_ADV_DarkBrave")
-- ▲直接出力
-- ▼直接出力
 --スチル表示
CloseTalkWindow()
show_image("102010010_StillImage", 0.0, 0.0, 0.3, false, false)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end(Camera004)
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ウレリー★★:ログレスに侵攻を続ける東の大国カレドニア
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040018")


	--★★ウレリー★★:バルバロイと戦える猛者たちも<br>ほとんどが喰い殺された
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040019")


	--★★ウレリー★★:最近になって<br>バルバロイという化け物を傘下に加え出した
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040020")

	change_face(Actor004,"Sad")

	--★★ウレリー★★:とてもログレス一国で対抗できる物量じゃない<br>普通の攻撃なんて効かない。兵の多くは倒れ──
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040021")


	--★★ウレリー★★:バルバロイと戦える猛者たちも<br>ほとんどが喰い殺された
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040022")

	change_face(Actor004,"Serious")

	--★★ウレリー★★:誰もが終わりだと思った<br>だけど
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040023")

-- ▼直接出力
 --スチル表示切替演出
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6)
wait_time(0.6)
show_image("101010140_1", 0.0, 0.0, 0.0, true, false)
set_scale_image(20,20)
wait_time(0.2)
fadein(0.1)
-- ▲直接出力
-- ▼直接出力
 --エフェクト、SE
 on_parent(FX_Camera1, Camera004, "", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
on_active(FX_Camera1)
se_play("SE_ADV_MA_01B111_03_Sword")
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
 --スチル表示②スチル差し替え
fadeout(0,0,0,1.0, 0.6)
wait_time(1.2)
show_image("still001", 0.0, 0.0, 0.0, true, false)
set_scale_image(1,1)
fadein(0.6)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
off_active(FX_Camera1)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ウレリー★★:<ruby=ランスロット>最強騎士</ruby>が<br>それを止めた
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040025")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ウレリー★★:ライエンスに深手を負わせ<br>絶望的な戦力差を覆し、敵を押し返したんだ
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040027")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Noon")
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:今ログレスがカレドニアと拮抗できているのは<br>彼のおかげと言っても過言じゃないかもね
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040031")

	change_face(Actor004,"Serious")

	--★★ウレリー★★:儀式の場はカレドニアの勢力圏の端っこ<br>向かうなら気をつけないと──
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040032")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor003,Camera003,EntryData110071_01_06,CameraAssetBundleName110071_01,CameraPos110071_01_106,Actor005,CharaPos110071_01_007,CharaPos110071_01_107)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:わたしが<br>ぶち抜くからご安心を
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_1040034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to Bow")
	change_face(Actor004,"Normal")

	--★★ウレリー★★:殿下、どうかご無事で
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040036")

	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:まっかせなさい
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_1040038")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end(Camera002)
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1040039")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.32)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
wait_time(0.71)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:もし学園に<br>いられなくなったとしても…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1040041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ウレリー★★:………
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1040043")

-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end(Camera002)
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:私、兄さんとなら<br>どこへだって行けるからね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1040045")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010010_StillImage", "content_still_10201001_image", "102010010_StillImage")
load_image_preload("still001", "content_still_10301032_image", "103010320_StillImage")
 load_image_preload("101010140_1", "content_still_10101014_image", "101010140_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_SwordWind", false, false)
preload_sound("BGM_ADV_DarkBrave")
preload_sound("BGM_Area_Noon")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
