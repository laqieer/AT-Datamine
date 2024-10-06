-- このluaスクリプトは、MA_01C111_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_07","110011_07_h")
Include("content_adv_advsmall_110011_07","Template110011_07_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_07_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_004)
	Camera002 = SetTemplate("Actor002",-10,CharaPos110011_07_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_003)
	InitializeTemplateRandomCamera110011_07()
	InitializeTemplate110011_07()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:どうしてこの時期は<br>魔女の力が増すんですか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050002")

-- ▼直接出力
 --PlayPartVoice("マーリン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:居残りで質問とは感心ですね<br>ふふ…では、お答えしましょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:このあいだの魔女ふたりも<br>以前より力が強まっているように見えました
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:それはこの時期が<br>秋から冬へ移り変わる季節だからです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050005")


	--★★マーリン★★:収穫の秋が終わり<br>生き物が眠る冬が始まる
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050006")


	--★★マーリン★★:実りから眠りへと移り行くこの時期は<br>現世と常世の境界が曖昧になるのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050007")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:眠りは死と近いものです<br>ゆえにこの時期の魔女は恐ろしい
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:その恐ろしさを忘れないため<br>人々は伝承を残したと言われています
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","納得")
-- ▲直接出力

	--★★ノワール★★:なるほど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("マーリン","肯定")
-- ▲直接出力

	--★★マーリン★★:もっとも今はもうすっかり<br>季節のお祭として根付いているようですが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050012")

-- ▼直接出力
 --PlayPartVoice("マーリン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:民衆とはたくましいものですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050013")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マーリン★★:なにかわからない点はありましたか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C111_050015","MA_01C111_050016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:突飛な思い付きかも知れないんですけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050018")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:祭を盛り上げることで魔女の増幅する力を<br>減らしたりとかは…さすがに無理か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050019")

-- ▼直接出力
 --PlayPartVoice("マーリン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マーリン★★:祭を盛り上げて魔女の力に対抗を…？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050021")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、いや<br>ただの思いつきなので…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:いえ、謙遜なさることはありません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マーリン★★:民衆の心は時に大きな力になります<br>祭を楽しむことで民の心を明るくさせられれば…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050025")

	change_face(Actor002,"Normal")

	--★★マーリン★★:その絆が、魔女を退ける<br>大いなる力となることもあるかもしれませんから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だとすると、やっぱりこの時期に<br>魔女と戦うのは得策ではないんでしょうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050028")

-- ▼直接出力
 --PlayPartVoice("マーリン","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:例えそうだとしても<br>向こうから来られれば戦わざるを得ません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050029")

	change_face(Actor002,"Sad")

	--★★マーリン★★:それこそ、このあいだのように
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050030")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("マーリン","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:…私としては時期を問わず<br>貴方たちを危険な目に遭わせたくはありませんが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050031")

	change_face(Actor002,"Anger")

	--★★マーリン★★:でも今はそんなことを言っていられる<br>状況ではないことも理解しているつもりです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050032")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:しばらく森にいたせいでしょうか<br>いまだに実感わかないところがあるんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050034")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:アーサーがあんなことに…<br>俺たちの敵になったなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050035")


	--★★ノワール★★:ガウェインだって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:………
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:だってこういうイベント<br>アーサーが一番好きそうじゃないですか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050038")


	--★★ノワール★★:みんなが祭で楽しんでいるのを見て<br>満足げに笑ったりして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050039")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール","落胆")
-- ▲直接出力

	--★★ノワール★★:…そう思うのは、俺がアーサーのことを<br>わかってないだけなんでしょうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_050040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン","否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:…いいえ。そんなことありません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050041")


	--★★マーリン★★:アーサー様は学園に通う皆が<br>青春を謳歌することを望んでいました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050042")


	--★★マーリン★★:その気持ちはきっと<br>偽りなどではないはずです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン","肯定2")
-- ▲直接出力

	--★★マーリン★★:ノワール様<br>貴方に対しても?
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C111_050044")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_07)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
