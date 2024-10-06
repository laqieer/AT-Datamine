-- このluaスクリプトは、MA_01A111_48.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
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
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:重苦しい空気が漂うなか、円卓の騎士たちは<br>今後について協議することとなった
	Talk(Actor009,"telop","narration","N","MA_01A111_481001")


	--★★テロップ★★:
	Talk(Actor009,"telop","narration","N","MA_01A111_481002")


	--★★テロップ★★:かくして病室の慈母モルガン先生は行方知れず
	Talk(Actor009,"telop","narration","N","MA_01A111_481003")


	--★★テロップ★★:『<ruby=エレイン>アストラットの美姫</ruby>』も重傷で面会謝絶<br><ruby=ラヴェイン>そのキラーズ</ruby>も付きっきりで生徒会も開店休業中
	Talk(Actor009,"telop","narration","N","MA_01A111_481004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★モルドレッド★★:かくして病室の慈母モルガン先生は行方知れず
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480002")


	--★★モルドレッド★★:『アストラットの美姫』も重傷で面会謝絶<br>そのキラーズも付きっきりで生徒会も開店休業中
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480003")


	--★★モルドレッド★★:聖杯探索班のご歴々もダウン<br>最強騎士まで復帰困難とは弱ったね
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★モルドレッド★★:おまけに銀卓騎士ガラハッドは──
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480006")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:ローマにダメージ与えてねえワケじゃねえ！<br>バルバロイだって随分ヤったぜ…！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_480008")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:バルバロイはいくらでも増やせんだろ？<br>二振り目の竜殺しが目覚めちまったんだろ？
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480009")


	--★★ケイ★★:騎士たちの傷を癒すことが先決だ…<br>全快するまで敵が待ってくれるとは思えんが
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A111_480011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:そしてもっともデケえ問題は──
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:…聖杯がローマに奪われたこと、だね<br>しかもただ奪うだけが狙いじゃなかったんだ…
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_480013")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★マーリン★★:４人の魔女の命により聖杯を穢れで満たし<br>触れた者を強大なバルバロイと化させ──
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A111_480014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:散々使い倒して我らの被害を大きくさせたうえで<br>聖杯を回収した…いつでも得られたでしょうに
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A111_480016")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ごめんなさい…ごめんなさいわたし<br>なにもできなくて、なにも…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_480017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A111_480019","MA_01A111_480020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアは俺を守ってくれたじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_480022")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:みんな、きずつけたんだよ………わたし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_480023")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたしじゃなかったら<br>もっとうまくできてたんじゃない…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_480024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アーサー★★:聖杯を穢した真の狙いは恐らく<br>継承者を討つことにあったのだろう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_480026")

	change_face(Actor005,"Sad")

	--★★アーサー★★:継承者を直接聖杯に触れさせるか<br>バルバロイと化した騎士に継承者を殺させるか
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_480027")

	change_face(Actor005,"Sad")

	--★★アーサー★★:先にガラハッドが触れてしまったことで<br>策は後者へと移行
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_480028")

	change_face(Actor005,"Sad")

	--★★アーサー★★:ヴェルナルス大将軍はお前たちを足止めし<br>聖杯探索班が疲弊するまで待った…
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_480029")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アーサー★★:そんなところだろう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_480031")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:ま。聖杯探索中から先手を打たれてたんだ<br>探しに行って魔女ブッ殺さなきゃ取られてたろ
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480033")


	--★★モルドレッド★★:スノードンでもガラハッドが触れなかろうが<br>どうせテメエら誰かが聖杯に触れてたんだ
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480034")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:ギネヴィアサマのせいじゃねえ<br>どっちにしたって詰んでたぜ
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:…気遣い、出来んだな。あんた
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_480037")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★モルドレッド★★:あ？早々に王手かけられてる陛下を<br>遠回しにディスってんのがわかんねえの？
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480038")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:…言いづらいけどさ、結果として聖杯は取られた<br>早く動かないとマズくない？
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_480040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:聖杯って…万人の願望を叶える器なんだろ…？<br>ルーシャスに願いを叶えられたら──
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_480041")

	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★マーリン★★:いいえ、彼らが今<br>聖杯で願いを叶えることは出来ません
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A111_480043")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:言い切れるんすか…！？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_480044")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:はい
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A111_480045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:聖杯の力は絶大。発現させるためには<br>それ相応の代償を支払う必要がある──はずです
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A111_480046")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★モルドレッド★★:ややこしいったらねえな
	Talk(Actor007,"CHRNAME_MORDRED","speech","L","MA_01A111_480047")


	--★★マーリン★★:でなければ…魔女やローマが聖杯奪取を<br>先送りにした理由に説明がつきません
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A111_480048")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力

	--★★トリスタン★★:確かにあっちが先に見つけてたんだから<br>願いを叶えられるならもう叶えているよね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_480049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:…ゆえに彼らがこれより動くとすれば<br>聖杯を使うよりも先に──
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01A111_480050")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アーサー★★:世界を終わらせに来る
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_480051")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
