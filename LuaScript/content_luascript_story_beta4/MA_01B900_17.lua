-- このluaスクリプトは、MA_01B900_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
load_image("10302020", "content_still_10302020_image", "103020200_StillImage")
on_cameraframe(2) 
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10302020", 0.0, 0.0, 0.0)
se_play("SE_ADV_MA_01B900_17_DeepWater_loop")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor002 = InitializeCharacter_2DOnly("101067","001","101067001")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:「これから先、お前には<br>４つの真実が明かされていく」
	Talk(Actor003,"telop","narration","N","MA_01B900_170002")


	--★★ノワール★★:（ランスロットと繋がり<br>共有される光景──…）
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01B900_170004")


	--★★テロップ★★:「それは…師匠が俺たちに遺してくれた記憶だ」<br>「それは師匠が秘めていた記憶の奥底の光景」
	Talk(Actor003,"telop","narration","N","MA_01B900_170005")


	--★★ノワール★★:（父さんが遺した４つの真実…<br>『聖杯』『妖精殺し』『妖精ニニアン』）
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01B900_170006")


	--★★テロップ★★:「聖杯や妖精の真実に近づくたびに<br>師匠の記憶が共鳴し、浸透していくことになる」
	Talk(Actor003,"telop","narration","N","MA_01B900_170007")


	--★★ノワール★★:（つまり、これが4つめ<br>最後の真実）
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01B900_170008")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ニニアン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ニニアン★★:罪を贖うべく私も命を捧げます<br>ですが呪いは拭いきれません…
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170009")


	--★★ノワール★★:（前の夢の、続き………？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B900_170011")

-- ▼直接出力
 --PlayPartVoice("ニニアン", "苦しみ")
-- ▲直接出力

	--★★ニニアン★★:頼めた義理ではない<br>それでもあの子だけは守りたい
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170012")

	change_face(Actor002,"Normal")

	--★★ニニアン★★:<dot>あの子</dot>に罪などありはしない
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170014")


	--★★ノワール★★:（………『あの子』？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B900_170016")


	--★★ニニアン★★:私が愛したユーサーとの──…
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170017")

	change_face(Actor002,"Sad")

	--★★ニニアン★★:過ちの道
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170019")

-- ▼直接出力
 --PlayPartVoice("ニニアン", "肯定")
-- ▲直接出力

	--★★ニニアン★★:選んだのはあの人だけじゃない<br>私もあの人を選んでしまった
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170021")

-- ▼直接出力
 --PlayPartVoice("ニニアン", "気合い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ニニアン★★:私の血が必要だというなら<br>私は喜んであの人に血を捧げる
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170023")

	change_face(Actor002,"Sad")

	--★★ニニアン★★:でも『＊＊＊＊＊』には幸せになってほしい
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170024")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（…？誰のことだ…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","MA_01B900_170026")

-- ▼直接出力
 --PlayPartVoice("ニニアン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ニニアン★★:妖精が聞いて呆れます、独善にも程があります<br>ですがブルーノ…貴方にしか託せない
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170027")


	--★★ニニアン★★:血の縁を得られず…家族など持てぬ妖精が<br>初めて、得てはならぬ人の子を産んだ
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170028")


	--★★ニニアン★★:我が子を護るべく<br>ブルーノの家族すら渦中に引きずり込む恥
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170029")

-- ▼直接出力
 --PlayPartVoice("ニニアン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ニニアン★★:だけど、最初で最後の家族くらいは
	Talk(Actor002,"CHRNAME_NINIAN","speech","L","MA_01B900_170030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10302020", "content_still_10302020_image", "103020200_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101067","001","101067001")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
