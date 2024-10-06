-- このluaスクリプトは、MA_01B110_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera006 = SetTemplate("Actor006",170,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_018,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_018)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor001,0.6,0.03,0.7,0)
lookat_weight(Actor004,0.6,0.03,0.7,0)
lookat_weight(Actor008,0.6,0.03,0.7,0)
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B110_351001")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B110_351002")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01B110_351004")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:聖杯探索班の諸君、ご苦労だった！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B110_350002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor006,true)
change_face(Actor003,"Normal")
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:『果てなき森』班はボクが同行したのだから<br>成功して当たり前だったけどね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_350003")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力

	--★★ヴォールス★★:聖杯を見つけていないのだから<br>成功とは言いがたい
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_350004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:銀卓騎士団の動きも気になる<br>油断できる状況ではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_350005")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:…せっかく盛り上げようとしていたのに<br>どうにも水を差すね、キミたちは
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_350007")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "納得")
-- ▲直接出力

	--★★マーリン★★:詳しく報告していただいても<br>よろしいでしょうか
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_350008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:ボクたち『果てなき森』班は<br>彼の地で魔女ティーテンと…
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_350009")

-- ▼直接出力
lookat_weight(Actor005,0.65,0.03,0.7,0)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:および銀卓の騎士アダンとそのキラーズに遭遇<br>見事これに勝利した
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_350010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:ティーテンを討ち<br>キラーズ・ソロモンを捕らえたものの
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_350011")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★パーシヴァル★★:残念ながら<br>アダンは取り逃がしてしまった
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_350012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:こちらも似たようなものだな<br>『滅びた都』の傍で魔女と銀卓騎士団と戦い
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_350013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴォールス★★:魔女ティートンを撃破し<br>キラーズ・ロンギヌスを拘束したものの
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_350014")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★ヴォールス★★:銀卓のひとり<br>マターヤには逃げられてしまった
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_350015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
set_enable_auto_lookat(Actor005,true)
lookat_weight_default(Actor005)
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…魔女を討ちキラーズは捕らえたが<br>銀卓の騎士は取り逃した…どちらも？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_350016")

	open_select_window_tag(Actor001,"Normal","MA_01B110_350017","MA_01B110_350018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしたんだ、難しい顔をして？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_350020")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:おかしいと思わないか？<br>どちらの班も同じ結果を迎えている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_350021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:できすぎている<br>何者かの思惑を感じるんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_350022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さすがだな、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_350024")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…？あ、ああ<br>ノワールもご苦労だったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_350025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしたんだ？<br>素直に喜べないないことでもあるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_350026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:２つの班の結果が似すぎていると思わないか？<br>手放しに成功と喜べない気がするんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_350027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★パーシヴァル★★:まあ結局聖杯は影も形もなかったわけだけどね<br>『聖杯城の巫女』殿に従ったところでさ？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","MA_01B110_350029")

	PlayAction(Actor007,"to  Std_Sad01")
	change_face(Actor007,"Sad")

	--★★フィエナ★★:そうかもね<br>でも…そうじゃないかも
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01B110_350030")

	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力

	--★★マーリン★★:私には、無駄なことなど<br>ひとつとしてないように思えます
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_350032")


	--★★マーリン★★:フィエナ様の聖杯感知も<br>探索班の皆様の動きも、恐らくは──
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_350033")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ヴォールス★★:なにか思うところが？
	Talk(Actor005,"CHRNAME_BORS","speech","L","MA_01B110_350034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★マーリン★★:宮廷魔導士の勘です。ただの勘ですが
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01B110_350035")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor003,true)
change_face(Actor006,"Normal")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★フィエナ★★:すこし…時間をちょうだい<br>フィエナちゃん、お役に立つから
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01B110_350036")

-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★ガラハッド★★:姉上…？
	Talk(Actor008,"CHRNAME_GALAHAD","speech","L","MA_01B110_350037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)

	--★★フィエナ★★:わからないことたくさんあるけど<br>私ならわかることもあるんだ
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01B110_350038")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★フィエナ★★:私もおじいちゃんっ子だからね<br>ガラハッドに負けないくらい
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01B110_350040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
