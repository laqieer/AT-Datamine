-- このluaスクリプトは、MA_01105_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_03","113011_03_h")
Include("content_adv_advsmall_113011_03","Template113011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos113011_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_003)
	InitializeTemplateRandomCamera113011_03()
	InitializeTemplate113011_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("103010350", "content_still_10301035_image", "103010350_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("103010360", "content_still_10301036_image", "103010360_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113012)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………やだ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_240002")

	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:ギネヴィア？
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01105_240004")


	--★★ギネヴィア★★:どんどん、夢がつぎはぎになってく………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_240005")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,70,0)
turn_chara(Actor002,-20,0)
lookat_weight(Actor001,0.7, 0.03, 0.7, 0.5,0)
lookat_weight(Actor002,1.0, 0.03, 0.7, 0.5,0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
se_play("SE_ADV_MA_01105_24_Knock")
wait_time(1.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:…はい
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01105_240007")

-- ▼直接出力
CloseTalkWindow()
show_image("103010350", 0.0, 0.0, 0,true,false)
wait_time(0.2)
-- ▲直接出力

	--★★皇帝ルーシャス★★:元気かな。余だ。皇太子だ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240009")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
hide_image(0)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…っ！？<br>ルー、シャス──…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_240010")


	--★★皇帝ルーシャス★★:気遣いは要らない<br>そのままでいなさい、ギネヴィア
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240011")

-- ▼直接出力
CloseTalkWindow()
show_image("103010360", 0.0, 0.0, 0,true,false)
wait_time(0.2)
-- ▲直接出力

	--★★皇帝ルーシャス★★:そのまま、引き籠っていていい
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240012")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
hide_image(0)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:どういう、意味…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_240013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★皇帝ルーシャス★★:そなたはこのログレス国の王妃殿下であり<br>キャメリアードからアーサーへの預かり物だ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★皇帝ルーシャス★★:価値ある存在なんだよ<br>滅多なことがあってはならない
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240015")

	change_face(Actor003,"Smile")

	--★★皇帝ルーシャス★★:クッククク…わかるかな？<br>どうして今まではワガママが許されていたか
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240016")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…わたし程度でも勝てそうな戦いだったから<br>アーサーたちが黙認してくれてた…っていうの？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_240017")

	change_face(Actor003,"Normal")

	--★★皇帝ルーシャス★★:違うのかな？気分が良かったろう？<br>いつもナイトに囲まれて
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_240019")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Angry")
turn_chara(Actor002,10,0.3)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネマウア★★:ルーシャス皇太子殿下<br>この子──ギネヴィアをどうされたいんです！？
	Talk(Actor002,"NPCNAME_0070","speech","L","MA_01105_240020")

	change_face(Actor003,"Sad")

	--★★皇帝ルーシャス★★:いやね──なんともわからないことがあってね<br>ある壮大な問いだ。それがなんともわからない
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★皇帝ルーシャス★★:だから、この学び舎で知れぬものかと<br>孤軍奮闘中なわけだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240022")


	--★★皇帝ルーシャス★★:なにを施せば得られるものか？<br>みなが求めるが果たしてそれほど良いものか？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240023")

	change_face(Actor003,"Sad")

	--★★皇帝ルーシャス★★:ギネヴィア、そなたならわからぬか？<br>余は知りたくてもどかしい
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240024")

	change_face(Actor003,"Normal")

	--★★皇帝ルーシャス★★:それは、すべての火種ゆえ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…ぜんッぜん、イミわかんない
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_240027")


	--★★皇帝ルーシャス★★:要は、こういうことだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240028")


	--★★皇帝ルーシャス★★:ログレスには余らが全面的に助力する<br>慕わしきギネヴィアを傷つけはしないよ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Surp")
change_face(Actor001,"Surp")
change_face(Actor002,"Surp")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
se_play("SE_ADV_MA_01105_24_Footstep")
-- ▲直接出力

	--★★皇帝ルーシャス★★:そなたはそこで<br>──ずっと夢を見ていればいい
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01105_240031")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("103010350", "content_still_10301035_image", "103010350_StillImage")
load_image_preload("103010360", "content_still_10301036_image", "103010360_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113012)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName113011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
