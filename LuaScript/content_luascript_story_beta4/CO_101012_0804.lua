-- このluaスクリプトは、CO_101012_0804.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-65,CharaPos114021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_005)
	Camera002 = SetTemplate("Actor002",160,CharaPos114021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_004)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.8, 0.6} , 1) 
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:修理、ちょっと時間がかかりそうだね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>思ったより破損がひどいみたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん<br>なにして時間を潰そうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040005")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…ねぇ、兄さん。ちょっと散歩しない？<br>ほら、あっち、海が見えるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040006")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:私、ちゃんと海を見たの<br>ずいぶん久々な気がする
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040008")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺も
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_08040011","CO_101012_08040012","CO_101012_08040013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:綺麗だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040015")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:へぇっ！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040016")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？どうした
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040017")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あ…あー、う、海だね！海の話だよね！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040018")

-- ▼直接出力
PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:私の顔、じっと見ながら言うんだもん<br>びっくりしちゃった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:海か…俺は湖のほうが好きだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040021")

-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:あはは。なにそれ<br>比べるものでもなくない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040022")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも、私も湖は好きだよ<br>兄さんとずっと一緒に暮らしてきた場所だもん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも、海は海で違った魅力がない？<br>すごく広くて、綺麗
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040024")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:海に向かって叫んでみるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040026")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:叫ぶって、なにを？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040027")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:海のバカヤロー！とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "否定")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:や、やだよそんなの！<br>なんか田舎者丸出しって感じじゃない！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040029")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040030")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…この海の向こうには<br>どんな世界が広がってるんだろう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040032")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:すべてが終わったら<br>ふたりで旅にでも出ようか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ふたりで…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040034")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…どうかしたか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…ううん。なんでもない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040037")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:…あ、修理そろそろ終わったんじゃないかな<br>行こう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040040")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:無事に直ってよかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:うん。これでトリスタンさんに<br>曲を作ってもらえるね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040043")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:歌詞を読んだら曲の構想が浮かんだって<br>言ってくれてたし、どんな曲ができるか楽しみ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:曲が出来たらいよいよコンサートだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08040045")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…うん。頑張らなきゃ<br>みんなのために！?
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08040046")

-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
