-- このluaスクリプトは、MA_01B900_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:あの日<br>止めようと思ったんだ、王殺し
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090002")


	--★★ガラハッド★★:…例えば、聖域化を先に成してしまって…<br>アーサー王の穢れだけを消す、とか…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090003")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★フィエナ★★:でもたぶん<br>それじゃあうまくいかない
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_090005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フィエナ★★:おじい様が言うには、聖杯は<br>この地の穢れを具現化させて聖域化を進める装置
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_090006")


	--★★フィエナ★★:今後この地に出現するであろうバルバロイや<br>今いるバルバロイには効果があるけど…
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_090007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:アーサーの血に宿ったバルバロイの因子には<br>影響を与えられない…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090008")


	--★★フィエナ★★:キラーズの力をもってしてもおじい様から<br>バルバロイ部分だけを除くなんて出来なかった
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_090009")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★フィエナ★★:同じようにアーサー王の穢れだけを<br>聖域化で払うことなんて、不可能…
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_090010")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:今のまま聖杯を使えば、ブリテンの穢れに加え<br>アーサーのバルバロイ化まで併発する恐れもある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_090011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B900_090012","MA_01B900_090013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットとアーサー<br>ふたりの選択を尊重しよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090015")

	change_face(Actor004,"Sad")

	--★★フィエナ★★:…そうだね<br>なにが正しいかなんてわからないけど
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_090016")

	change_face(Actor001,"Sad")

	--★★ノワール★★:死が免れないのなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090017")

	change_face(Actor001,"Sad")

	--★★ノワール★★:いちばん信じている人に<br>見送ってもらえるなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドは優しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090020")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ノワールも苦しそうな顔をしている<br>だろう？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090021")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:だけどふたりの話を聞いたら<br>止められないと
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090022")

	goto Block1end

::Block1end::
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:あるいは最初から<br>そのために今日まで戦ってきたのだとしたら
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090024")

	PlayAction(Actor002,"to  Std_No")

	--★★ランスロット★★:買いかぶり過ぎだ。ガラハッド<br>俺はそこまで利他主義じゃない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_090025")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★フィエナ★★:「そのために」…って<br>どういうこと？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_090026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…アーサーを殺すために？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090027")


	--★★ノワール★★:マーリン様の言葉を借りれば──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090029")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:「世の救済へ導く妖精からかかった呪いは<br>世の崩壊を招くバルバロイを誕生させる」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090030")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:自分では止められないバルバロイの王たる力<br>討つには強き他者の力が要る…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090031")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガラハッド★★:そのアーサーを超えるためにランスロットは<br>最たる強さを求め、努力し続けたんじゃないのか
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090033")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:………そうでもある、が
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_090035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それだけのための強さではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_090037")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_090038")

	change_face(Actor003,"Sad")

	--★★ガラハッド★★:…だから、その…わかると言うには<br>ガラハッドは相応しくないかもしれないが
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:ランスロットの苦しみは、少しは理解したいから<br>なんというか、言葉が出て来ないが…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090040")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…ありがとう。ガラハッド
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_090041")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:お爺様も…安らかに逝かれたはずだ<br>ガラハッドへの、気遣いだったのかもしれないが
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090042")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_090043")


	--★★ガラハッド★★:望む相手に、望ましい最期を与えることは…<br>…その道しか残っていなかったのだとしても
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:きっと、罪や咎ではないはずだ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_090045")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
