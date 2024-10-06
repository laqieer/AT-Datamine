-- このluaスクリプトは、MA_01C201_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_007)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
 --arufa = 0.055
--setup_small_camera_resetting(Actor001,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
--set_rot(Actor001,{2,CharaPos110141_02_001[4],0})
DontCameraOffset(Actor001)
lookat_delay_weight_reset(Actor001,1)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_D_Pain")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor002, 0.9, 0, 0.5, 0.35,0.5)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Sing_Side_Bed")
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115150)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ディナタン★★:ギネヴィアさん、調子はどうですか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210002")

	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:…うん。だいぶよくなった<br>ディナタンの看病のおかげかも
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210003")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ねえ、ディナタン<br>歌ってよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210005")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ギネヴィア★★:ディナタンの歌は<br>みんなを元気にしてくれるっていうじゃない？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210006")

	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:わたしも元気になりたい
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…はい！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210008")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Sing_Side_Bed")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
 --ディナタンの歌
wait_time(10.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_D_Pain")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:やっぱりディナタンの歌はいいな<br>元気が湧いてくる
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:よかった…！<br>それじゃ、もっと歌いますね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210012")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:ギネヴィアさん、リクエストはありますか？<br>私の知ってる歌ならなんでもいいんですよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:…ありがとう<br>ディナタンって、ほんとイイコよね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:そ、そんな…そんなことないですよ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210015")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ううん。イイコだよ、すごく<br>だから――イヤになる
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210016")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ギネヴィアさん…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210017")


	--★★ギネヴィア★★:その力が妖精の力だなんて<br>知らなければよかった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210018")


	--★★ディナタン★★:…なんの話をしてるんですか<br>ギネヴィアさん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210019")


	--★★ギネヴィア★★:あなたも薄々気がついてるんでしょう？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210020")


	--★★ギネヴィア★★:人ならざる者の力だって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210021")


	--★★ディナタン★★:人ならざるもの…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:人は人の力だけで生きることが<br>できるはずだってアーサーは言った
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210023")


	--★★ギネヴィア★★:伝説や妖精の力なんて借りずに
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210024")


	--★★ディナタン★★:…ギネヴィアさん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210025")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:あなたがこんなにやさしくなければ<br>よかったのに
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210026")


	--★★ギネヴィア★★:ごめんね、ディナタン
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210027")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:わたし、ディナタンを<br>連れていきたいところがあるの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210028")


	--★★ギネヴィア★★:あなただけを<br>マルディサントもノワールも抜きでね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210029")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…私を、連れていく？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_210030")


	--★★ギネヴィア★★:ええ。一緒に来てもらえる？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210031")

-- ▼直接出力
 --setup_small_camera_end()
setup_small_camera_start(Camera001) --暗転時にキャラを消すのででカメラを固定
-- ▲直接出力

	--★★ギネヴィア★★:――アーサーのところへ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C201_210032")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0, 0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
Appear(Actor003)
Hide(Actor001)
Hide(Actor002)
setup_small_camera_start(RndCamera005)
off_active(huton)
--フェードイン
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
fadein(BLACK_WHITE_TIME+ BLACK_WHITE_WAIT_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:…ディーナ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C201_210034")


	--★★マルディサント★★:ディーナの気配が…<br>消えた？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C201_210035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_D_Pain")
preload_sound("BGM_ADV_Sing_Side_Bed")
	InitializeLoad_Preload()
	load_area_scene_preload(115150)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
