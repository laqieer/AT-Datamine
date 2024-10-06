-- このluaスクリプトは、MA_01A110_46.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110261_42","110261_42_h")
Include("content_adv_advsmall_110261_42","Template110261_42_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",180,CharaPos110261_42_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110261_42,CameraPos110261_42_001)
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
load_sound("BGM_ADV_Theater")
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,1.167,1.743,18.73)
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
	Actor001 = InitializeCharacter_3D("101030","003","101030003","content_animationpack__common","FacialPack","Actor001")
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

	--★★エレイン★★:「なんと情けない！<br>道化しか下せぬとは！」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460002")

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

	--★★エレイン★★:「ああっ、<ruby=わたし>貴方</ruby>は見るに堪えない！」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460004")


	--★★エレイン★★:「名乗り出てその体たらく<br>目も当てられない！」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460006")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★エレイン★★:「私が探すは、黒き楯の冒険を引き継ぐ者！<br>巨悪を断つ騎士様は<ruby=いずこ>何処</ruby>か！？」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460007")

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

	--★★テロップ★★:王女は嘆く<br><dot>不甲斐なき己</dot>を口汚く罵りながら
	Talk(Actor004,"telop","narration","N","MA_01A110_460009")


	--★★テロップ★★:世界を救う後ろ盾となるべく<br>奮い立つ勇敢な騎士に憧れを抱きながら
	Talk(Actor004,"telop","narration","N","MA_01A110_460011")


	--★★テロップ★★:王女は騎士のその背に手が届くのか<br>手を伸ばして良いのだろうか
	Talk(Actor004,"telop","narration","N","MA_01A110_460012")


	--★★テロップ★★:しかし目の当たりにしてしまった
	Talk(Actor004,"telop","narration","N","MA_01A110_460013")


	--★★テロップ★★:汚名にまみれ、装束を黒く染め切ってでも<br>戦場を這いずり続ける不屈の騎士を
	Talk(Actor004,"telop","narration","N","MA_01A110_460014")

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
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_460016")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Sad")

	--★★エレイン★★:「騎士様…こんな危険を賭してまで<br>どうして私なんかを助けてくださるのですか」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:「臆病で…けれどみんなを助けたいと<br>望みばかりが果てしない、欲張りな私を」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460018")


	--★★マルディサント★★:「貴方がその優しい望みを叶えるために<br>懸命に頑張っていることを私は知っています」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_460019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:「そんな貴方を私はお守りしたいのです」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_460020")

	change_face(Actor001,"Shy")

	--★★エレイン★★:「あなたが隣にいる。それだけでこの困難も<br>たやすく乗り越えていける気がします」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★エレイン★★:「ひとつ誓いを立ててもらえますか？」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460022")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Kneeling")
-- ▲直接出力

	--★★マルディサント★★:「なんなりと」
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_460023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★エレイン★★:………あ、えっと
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460025")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Woodstd02")
-- ▲直接出力

	--★★マルディサント★★:姫…？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A110_460026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001, lookoj, "kara")
lookat_weight(Actor001, {1.2, 0, 0.5, 0})
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",0.3)
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★エレイン★★:あの………、あ、の………
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460027")

	change_face(Actor002,"Sad")

	--★★マルディサント★★:（…台詞、忘れやがったな…！<br>この流れじゃフォローも不自然だ、どーする…！）
	Talk(Actor002,"CHRNAME_MALADISANT","mind","L","MA_01A110_460028")


	--★★マルディサント★★:うまく口にできません<br>自分の気持ちを、いつもいつも
	Talk(Actor002,"CHRNAME_MALADISANT","mind","L","MA_01A110_460038")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
wait_time(2.0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.4)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★エレイン★★:………うまく、デキないことばかりです
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460030")

-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★エレイン★★:うまく口にできません<br>自分の気持ちを、いつもいつも
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460032")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★エレイン★★:ですが<br>飾ることなく述べるのならば
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★エレイン★★:尊敬しています<br>騎士であるみなさんを
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460035")

-- ▼直接出力
bgm_play("BGM_To_End")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★エレイン★★:…私も、がんばりますから<br>貴方の背を見ながら──
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:その後ろに立って
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A110_460037")

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
preload_sound("BGM_ADV_Theater")
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(110261)
	InitializeCharacter_3D_Preload("101030","003","101030003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","002","101017002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","007","101009007","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110261_42)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
