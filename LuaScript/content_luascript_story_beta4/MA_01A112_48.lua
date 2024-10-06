-- このluaスクリプトは、MA_01A112_48.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera006 = SetTemplate("Actor006",160,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
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
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01A112_481001")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01A112_481002")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01A112_481003")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01A112_481004")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01A112_481005")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ガウェイン★★:…勝っても嬉しくねー喧嘩ばっかだ
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","MA_01A112_480002")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:終わりの余震とやらは過ぎ去ったと見るが<br>それを防ぐべく、騎士たちは疲弊…
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01A112_480003")


	--★★ケイ★★:ルーシャスはアーサーたちを見逃して去った、が<br>バルバロイ異常増殖による被害も大きく──
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01A112_480004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ケイ★★:すべてきゃつの掌の上<br>踊らされているようにさえ感じるな
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01A112_480005")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor007,true)
set_enable_auto_lookat(Actor008,true)
-- ▲直接出力

	--★★ガウェイン★★:もともと分が悪ィんだよ！<br>数も、環境も、最初からケタ違いだった
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","MA_01A112_480006")

	change_face(Actor007,"Normal")

	--★★ケイ★★:だがそれが戦というものだ<br>敵の内部を探り、主導権を握り、的確な策で…
	Talk(Actor007,"CHRNAME_KAY","speech","L","MA_01A112_480007")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(2,Actor008,"Anger")

	--★★ガウェイン★★:あんたどっちの味方なんだよ！
	Talk(Actor008,"CHRNAME_GAWAIN","speech","N","MA_01A112_480008")

-- ▼直接出力
 --PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor007,"Anger")

	--★★ケイ★★:島国の一王国と大陸の大帝国では<br>分が悪すぎると言ってるだけだ！
	Talk(Actor007,"CHRNAME_KAY","speech","N","MA_01A112_480009")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(2,Actor008,"Surprise")

	--★★ガウェイン★★:そーだよ！それ俺言ったんだよ！<br>なんだわかってんじゃねーか！クッソー！
	Talk(Actor008,"CHRNAME_GAWAIN","speech","N","MA_01A112_480010")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor007,1)
lookat_delay_weight_reset(Actor008,1)
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:だが、得るものも大きかった
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:勝利と
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_480012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:そして、聖杯ね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480013")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:モルガンが『贈り物』と言っていたものが<br>それでしょうね
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A112_480015")

	open_select_window_tag(Actor001,"Normal","MA_01A112_480017","MA_01A112_480018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モルガン先生が遺してくれたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_480020")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ガラハッドを穢した聖杯は<br>魔女が吸収して持ち去った…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480021")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:魔女と同化したモルガン先生が<br>最後の力を振り絞って遺してくれた、のかもね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:偶然だろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_480025")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:きっと、違うと思います<br>違うと思いたい
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_480026")

	change_face(Actor003,"Sad")

	--★★エレイン★★:魔女と同化したモルガン先生がきっと…<br>最後の力を振り絞って遺してくれたんです
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_480027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:それでどうするわけ、これから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480029")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★マーリン★★:ルーシャスの狙いも所在もわからない以上<br>ことを起こすのならば急がねばなりませんね
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A112_480030")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:奪われたもの…多すぎるからね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480031")

	change_face(Actor006,"Anger")

	--★★マーリン★★:魔女モルガンの膨大な力の共鳴により<br>バルバロイの増殖速度は以前の比ではありません
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A112_480032")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:だが我らは聖杯を手に入れ…カレドニアを解放し<br>ブリテンの平穏をひとときだが勝ち取った
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480033")


	--★★アーサー★★:ギネヴィアが落ち着き次第…彼女の意志次第だが<br>聖杯による『聖域化』の備えを始める
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:『聖域化』？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_480035")


	--★★ギネヴィア★★:わたしの意志次第、って何よ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:バルバロイ全滅させられるんでしょ？<br>答えは決まってるわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480037")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:詳細は後日だ。ルーシャスの捜索は急がせる<br>お前たちは少しでも長く…休んでくれ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…ヘンなの<br>急げって言ってみたり休めって言ってみたり
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480039")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ま。降誕祭ももうすぐだしね<br>休まなきゃもたないのも事実かな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_480040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:ルーシャスは魔女すべての力を取り込んだ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480042")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:奴自身のバイブスの力も相まって<br>モルガンを凌駕する力を得たとみて間違いない…
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480043")

	change_face(Actor005,"Serious")

	--★★アーサー★★:だが<br>死んでなるものか
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480044")


	--★★アーサー★★:癒す必要すらない場所にしよう<br>生き残り、死んだ者の遺志を継ぎ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:…楽しい<br>学園にしていこう、みんな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_480047")

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
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
