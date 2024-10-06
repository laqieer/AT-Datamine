-- このluaスクリプトは、CO_101010_0604.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114061_01","114061_01_h")
Include("content_adv_advsmall_114061_01","Template114061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_004)
	InitializeTemplateRandomCamera114061_01()
	InitializeTemplate114061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:やっぱり落ち着くな、ここにいると
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:ああ、昔を思い出すな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:師匠はな。湖の妖精の守護のためこの村を訪れ<br>お前の母上と出会ったらしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_06040006","CO_101010_06040007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それ…父さんの記憶に遺ってたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040009")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:いいや。師匠が教えてくれたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040010")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:師匠は懐かしそうに語っていたよ<br>母上と知り合って、お前が産まれて…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040011")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:家族水入らずの時間は<br>なにものにも代えがたい幸せだったと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040012")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…そっか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:本当に、いい家族だ<br>お前たちは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040014")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたも家族だろ<br>他人行儀なこと言うなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…そうだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:父さんと母さん<br>どっちから先に声をかけたんだろうな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040019")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:…面白がってないか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040020")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そりゃ気になるだろう<br>俺はふたりの子供なんだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:やれやれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040022")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ランスロット★★:知ってのとおり<br>お前の母上は妖精の侍女だった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040024")


	--★★ランスロット★★:ともに妖精のそばにいるうちに<br>師匠と母上とはしだいに心を通わせていった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:妖精も含め周囲の皆が祝福したらしい<br>ふたりの婚姻、そしてお前の誕生をな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040026")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…なんだか照れ臭いな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040028")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:どうしてだ<br>いい話じゃないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040029")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前は師匠にも、皆にも<br>愛されて生まれてきたという――
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040030")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:だから、そういうのが<br>なんというかさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:どういうことだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040032")

-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:芯の強い女性だったな<br>お前の母上は
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ。芯も気も強い人だった<br>父さんはいつも尻に敷かれてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040035")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:そういえば…そうだったような気もするな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040036")

	change_face(Actor001,"Normal")

	--★★ノワール★★:母さん、優しいけど怒ると怖かったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:惚れた弱み、というやつかもしれんな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040038")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それも父さんの記憶なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:いや<br>ただの俺の想像だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040040")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ええー…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:恋だなんだというのは<br>俺にはよくわからない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040042")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:あー…そうだな<br>ランスロットは鈍感だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040043")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:…そうなのか？<br>自分ではそんなつもりはないんだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040044")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:ディナタンに<br>相談したほうがいいだろうか…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_06040046")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そういうのを女の子に聞いちゃうところが<br>鈍感なんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_06040048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
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
	load_area_scene_preload(114061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
