-- このluaスクリプトは、MA_01A110_44.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110261_42","110261_42_h")
Include("content_adv_advsmall_110261_42","Template110261_42_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",180,CharaPos110261_42_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110261_42,CameraPos110261_42_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110261_42_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110261_42,CameraPos110261_42_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110261_42_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_05_StdController","to Std_Loop",CameraAssetBundleName110261_42,CameraPos110261_42_003)
	InitializeTemplateRandomCamera110261_42()
	InitializeTemplate110261_42()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10102006)
off_active(prop001)
-- ▲直接出力
-- ▼直接出力
prop001_offset  = {-0.06,-0.01,0,0,-170,0}
-- ▲直接出力
-- ▼直接出力
on_parent(prop001,Actor003, "J_Hand_R", prop001_offset)
-- ▲直接出力
-- ▼直接出力
prop002 = setup_prop_object(10102006)
off_active(prop002)
-- ▲直接出力
-- ▼直接出力
prop002_offset  = {-0.06,-0.01,0,0,0,180}
-- ▲直接出力
-- ▼直接出力
on_parent(prop002,Actor003, "J_Hand_L", prop002_offset)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
sword001 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
off_active(sword001)

-- ▲直接出力
-- ▼直接出力
sword001_offset  = {-0.07,-0.02,0,0,-170,0}
-- ▲直接出力
-- ▼直接出力
on_parent(sword001,Actor001, "J_Hand_R", sword001_offset)
off_parent(sword001)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Theater")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110261)
	Actor001 = InitializeCharacter_3D("101011","003","101011003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","002","101017002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","007","101009007","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:「なんと情けない！<br>道化しか下せぬとは！」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440002")

-- ▼直接出力
bgm_play("BGM_ADV_Theater")
-- ▲直接出力
-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:「ああっ、貴方は見るに堪えない！」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440004")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:「名乗り出てその体たらく<br>目も当てられない！」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:「わたしが探すは、黒き楯の冒険を引き継ぐ者！<br>巨悪を断つ騎士様は<ruby=いずこ>何処</ruby>か！？」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440006")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0, 0, BLACK_WHITE_TIME,FALSE,FALSE)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
butai_souchi = setup_prop_object(10102007)
set_pos(butai_souchi ,{0,0,0})
turn_chara(Actor001,110,0)
Appear(Actor003)
Appear(Actor002)
set_enable_auto_lookat(Actor003, false)
PlayActionDirect(Actor003,"to Woodstd")
on_active(prop001)
on_active(prop002)
-- ▲直接出力

	--★★テロップ★★:王女は探す<br>口汚く罵りながら
	Talk(Actor004,"telop","narration","N","MA_01A110_440008")


	--★★テロップ★★:世界を救う後ろ盾となるべく<br>奮い立つ勇敢な騎士を
	Talk(Actor004,"telop","narration","N","MA_01A110_440009")


	--★★テロップ★★:王女自身がその背を任せ合える…<br>心許せる無二の相手を
	Talk(Actor004,"telop","narration","N","MA_01A110_440010")


	--★★テロップ★★:そして目を留めた
	Talk(Actor004,"telop","narration","N","MA_01A110_440011")


	--★★テロップ★★:汚名にまみれ、装束を黒く染め切ってでも<br>戦場を這いずり続ける不屈の騎士に
	Talk(Actor004,"telop","narration","N","MA_01A110_440012")

-- ▼直接出力
bgm_play("BGM_To_Transition_Fade0time")
-- ▲直接出力
-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor002,"to Bow")

	--★★マルディサント★★:「姫、遅くなり申し訳ありません<br>お助けに参上しました」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_440014")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:「ああ、騎士様<br>まさか助けに来てくれるなんて」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:「自由に憧れ、何もない平穏に退屈していた<br>こんな身勝手で、ワガママな王女を」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440016")


	--★★マルディサント★★:「それはもう遠い昔のこと<br>今の貴方は誰よりもこの国を想っている」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_440017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:「そんな貴方を私はお守りしたいのです」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_440018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:「あなたが隣にいる。それだけでこの困難も<br>たやすく乗り越えていける気がします」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440019")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:「ひとつ誓いを立ててもらえますか？」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440020")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Kneeling")
-- ▲直接出力

	--★★マルディサント★★:「なんなりと」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_440021")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:…ぷーっ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440023")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Woodstd02")
-- ▲直接出力

	--★★マルディサント★★:…姫<br>なにを笑って？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_440024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:あっ、あー…えーと、いいえ、あ～
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440025")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:（演技中に噴き出してンじゃねェー！！<br>オニーサンが木なのは笑えっけどッッ！！）
	Talk(Actor002,"CHRNAME_MALADISANT","mind","L","MA_01A110_440026")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,1.2,0,0.5,0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
wait_time(1.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:………あなたと出会えて
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:ようやく笑えたみたいなの。わたし
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440029")

-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:「死ぬことは禁じます」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440031")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor001,"to baptism01")
-- ▼直接出力
on_active(sword001)
on_parent(sword001,Actor001, "J_Hand_R", sword001_offset)
se_play("SE_Handling_Swd_001")
-- ▲直接出力

	--★★ギネヴィア★★:「飾ることなくお願いします<br>悪虐の王を討ち果たす力となってください」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:「わたしも誓います。常に傍らにあって<br>あなたとともに行くことを」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440033")

-- ▼直接出力
bgm_play("BGM_To_End")
-- ▲直接出力
	PlayAction(Actor001,"to baptism02")

	--★★ギネヴィア★★:「わたしも、あなたも、互いが互いの──」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:「後ろ盾として」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_440035")

-- ▼直接出力
se_play("SE_ADV_MA_01C110_39_Cheers")
wait_time(7.0)
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
setup_prop_object_preload(10102006)
prop001_offset  = {-0.06,-0.01,0,0,-170,0}
setup_prop_object_preload(10102006)
prop002_offset  = {-0.06,-0.01,0,0,0,180}
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
sword001_offset  = {-0.07,-0.02,0,0,-170,0}
preload_sound("BGM_ADV_Theater")
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(110261)
	InitializeCharacter_3D_Preload("101011","003","101011003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","002","101017002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","007","101009007","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110261_42)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
