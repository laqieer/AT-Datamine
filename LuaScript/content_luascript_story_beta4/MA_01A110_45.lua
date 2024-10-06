-- このluaスクリプトは、MA_01A110_45.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",0,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
load_image("101030170", "content_still_10103017_image", "101030170_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,2.661,0.842,-2.444)
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102018)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","003","101011003","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:主演女優の呼び出しに<br>快く応えてくれて感謝します
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:休まなくていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:あのね、おねだりしたいの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450004")

	change_face(Actor001,"Smile")

	--★★ノワール★★:久しぶりだな、それ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450005")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…ちょっとね<br>うまくいかなかったんだあ本番
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:一瞬ハラハラしたけど<br>感動したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450008")


	--★★ギネヴィア★★:全然だめ、クライマックスでね<br>うまく感情が乗らなかったの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:出たものがすべてだよ<br>ああいうのは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:やり直したいの！<br>だからノワール、あなたが騎士の代役やって！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:台詞くらい覚えてるでしょ？<br>ずっと練習付き合ってもらってたんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450012")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えええ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450013")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:「ああ、騎士様<br>まさか助けに来てくれるなんて」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450015")


	--★★ギネヴィア★★:「自由に憧れ、何もない平穏に退屈していた<br>こんな身勝手で、ワガママな王女を」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:「それはもう遠い昔のこと<br>今の貴方は誰よりもこの国を想っている」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:「そんな貴方を私はお守りしたいのです」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450018")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:「あなたが隣にいる。それだけでこの困難も<br>たやすく乗り越えていける気がします」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450019")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002, lookoj, "kara")
lookat_weight(Actor002, {0.8, 0.2, 0.8, 0.5})
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:………
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450020")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450021")

-- ▼直接出力
lookat_delay_weight_reset(Actor002 ,0.2)
-- ▲直接出力

	--★★ギネヴィア★★:…ひとつ誓いを立ててもらえますか？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450023")


	--★★ノワール★★:なんなり、と――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_450024")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{1.78, 0, -1.416}, 1.5)
wait_time(1.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
show_image("101030170", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
wait_time(STILL_SWITCH_TIME )
scale_to_image(1.462,1.462,25.0,"EaseInOut")
move_to_image(400,-370,25.0,"EaseInOut")
wait_time(STILL_ACTIVE_AFTER)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:…──ん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:良い思い出が、あなたと欲しい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450028")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ごめんね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:冷たいでしょ、くちびる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450031")


	--★★ギネヴィア★★:体温なんてないみたいで<br>当たり前よね、戦いに必要ないもん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450032")


	--★★ギネヴィア★★:ぬくもりも遺せない<br>でもそれが、武器になるってことなんだよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450033")


	--★★ギネヴィア★★:あなたの武器になるって<br>わたしが、選んだ道
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450034")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ギネヴィア…
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01A110_450035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…ね。もしわたしが聖遺物化したら<br>なにが遺るのかな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450036")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あなたはきっと<br>わたしのことを忘れないでいてくれる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450037")

-- ▼直接出力
 --setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………でも、わたし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_450038")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 1.5)
wait_time(1.5)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
 fadein(0.6)
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あなたの良い思い出に<br>なっちゃうのは、イヤだなあって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_450040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030170", "content_still_10103017_image", "101030170_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10102018)
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","003","101011003","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
