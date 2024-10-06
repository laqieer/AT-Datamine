-- このluaスクリプトは、MA_01B111_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_02","112021_02_h")
Include("content_adv_advsmall_112021_02","Template112021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_001)
	InitializeTemplateRandomCamera112021_02()
	InitializeTemplate112021_02()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116024)
	Actor001 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("リリアーナ", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★リリアーナ★★:気候が違うんだ…<br>だからこんなに育つ野菜が違うんだ…
	Talk(Actor001,"CHRNAME_LILIANA","speech","L","MA_01B111_170002")

-- ▼直接出力
 --PlayPartVoice("市民中年_男1", "挨拶")
-- ▲直接出力

	--★★市民（中年男）★★:オッ、学園の生徒さん！<br>どうだい、お安くしとくよ！
	Talk(Actor003,"NPCNAME_0157","speech","N","MA_01B111_170003")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★リリアーナ★★:ひっ、ひえっ、いえっ、あのぉ私…っ<br>来たばっかりで生徒というにはまだ未熟な…！
	Talk(Actor001,"CHRNAME_LILIANA","speech","L","MA_01B111_170004")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("市民中年_男1", "肯定3")
-- ▲直接出力

	--★★市民（中年男）★★:いつもログレス守ってくれてる礼だ！<br>ほらひとつ持ってきな！
	Talk(Actor003,"NPCNAME_0157","speech","N","MA_01B111_170005")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:あの、いえ、私は、見てただけでぇ…！<br>ひやかしのつもりでもないんですがぁ…！
	Talk(Actor001,"CHRNAME_LILIANA","speech","L","MA_01B111_170006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:買いましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170008")

-- ▼直接出力
 --PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★リリアーナ★★:カシウス──…いえ、クレア
	Talk(Actor001,"CHRNAME_LILIANA","speech","L","MA_01B111_170009")

-- ▼直接出力
 --PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:見ない顔の子に店員さんが無料で商品を渡す<br>このあと考えられる展開はふたつ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170010")


	--★★クレア★★:良い子であればお返しを考える
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:やましい気持ちを持つ子なら<br>この商店を避けるようになる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170012")


	--★★クレア★★:顔を覚えられては動きにくいでしょうからね<br>そうやって動向を探るジャブを打っておくの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170013")


	--★★クレア★★:定型にハマらない子もいるけれどね<br>まあ捜査線は幾重にもあったほうがいい
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クレア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ということで店員さんは私の協力者<br>リリアーナ、貴方はどういう子かしらね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170015")

-- ▼直接出力
 --PlayPartVoice("市民中年_男1", "笑い")
-- ▲直接出力

	--★★市民（中年男）★★:クレア嬢～<br>ネタばらしが早いですよ
	Talk(Actor003,"NPCNAME_0157","speech","N","MA_01B111_170017")

-- ▼直接出力
 --PlayPartVoice("クレア", "笑い")
-- ▲直接出力

	--★★クレア★★:いつもありがとう<br>でもこの子は私が見ているから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170018")

-- ▼直接出力
 --PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★リリアーナ★★:………疑い深いですね、クレア
	Talk(Actor001,"CHRNAME_LILIANA","speech","L","MA_01B111_170019")

-- ▼直接出力
 --PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:信頼出来る仲間はひとりでも多く欲しい<br>滅多なことをしなければいいのよ。だけど──
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170020")


	--★★クレア★★:ペレス王を貫いた犯人は貴方<br>それは容疑を通り越した純粋な事実
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:一度その手を血で汚した貴方…<br>二度目の躊躇をするかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170023")

	change_face(Actor001,"Anger")

	--★★リリアーナ★★:………しますよ
	Talk(Actor001,"CHRNAME_LILIANA","speech","L","MA_01B111_170025")

	change_face(Actor002,"Surprise")

	--★★クレア★★:へえ？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","MA_01B111_170026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:罪滅ぼしを
	Talk(Actor001,"CHRNAME_LILIANA","speech","L","MA_01B111_170027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116024)
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
